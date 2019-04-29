using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MRK_Udp_Server_HTV
{
    enum Command
    {
        Login,      //Log into the server
        Logout,     //Logout of the server
        Message,    //Send a text message to all the chat clients
        List,       //Get a list of users in the chat room from the server
        Null        //No command
    }

    public partial class main : Form
    {
        struct ClientInfo
        {
            public EndPoint endpoint;   //Socket of the client
            public string strName;      //Name by which the user logged into the chat room
        }

        //The collection of all clients logged into the room (an array of type ClientInfo)
        ArrayList clientList;

        //The main socket on which the server listens to the clients
        Socket serverSocket;

        byte[] byteData = new byte[1024];

        public main()
        {
            clientList = new ArrayList();
            InitializeComponent();
            refreshListView();
        }
       
        
        private DbUdpHTVEntities  db = new DbUdpHTVEntities();
        int sendPort = 9311;
        private byte[] data = new byte[2048];
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private int receivedDataLength;

        public  void sendMessage(string response,IPEndPoint ep)
        {
            string ip = ep.Address.ToString();
            if (db.TVs.Where(s => s.IP == ip).ToList()[0].status == false)
            {
                listBoxLog.Items.Add(ep.Address.ToString() + " - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": sendMessage Exception Tv status is off");
            }
            else
            {
                byte[] message = Encoding.ASCII.GetBytes(response);
                //serverSocket.BeginSendTo(message, 0, message.Length, SocketFlags.None, (EndPoint)ep, new AsyncCallback(OnSend), null);
                serverSocket.SendTo(message, message.Length, SocketFlags.None, (EndPoint)ep);
            }
        }
        public async void sendMessageTo(string IP, int Port, string Message)
        {
            IPEndPoint sendTo = new IPEndPoint(IPAddress.Parse(IP), Port);
            EndPoint remoteTo = (EndPoint)sendTo;
            socket.SendTo(Encoding.ASCII.GetBytes(Message), Message.Length, SocketFlags.None, remoteTo);
        }
        public async void HandelMessage(string josn, IPEndPoint EP)
        {
           

            try
            {
                string ip = EP.Address.ToString();
                JObject obj = new JObject();
                JsonLoadSettings a = new JsonLoadSettings();
                JObject MSG = JObject.Parse(josn);
                string command = (string)MSG.SelectToken("command");
                switch (command)
                {
                    case "register":
                        register(EP);
                        break;
                    case "power":
                        if (MSG.SelectToken("data").ToString().ToLower() == "on")
                        {
                            obj["command"] = "response";
                            obj["type"] = "power";
                            obj["data"] = "on";
                            db.TVs.Where(s => s.IP == ip).ToList().ForEach(x => x.status = true);
                        }
                        else if (MSG.SelectToken("data").ToString().ToLower() == "off")
                        {
                            db.TVs.Where(s => s.IP == ip).ToList().ForEach(x => x.status = false);
                        }
                        db.SaveChanges();
                        sendMessage(obj.ToString(),EP);
                        break;
                    case "time":
                        tvTime(MSG, EP);
                        break;
                    case "get_network_device":
                        complateRegister(MSG, EP);
                        break;
                }
            }
            catch(Exception ex)
            {
                listBoxLog.Items.Add(EP.Address.ToString() + " - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": main_Load Exception " + ex.Message);
                return;
            }
        }
        public void register(IPEndPoint EP)
        {
            string ip = EP.Address.ToString();
            JObject obj = new JObject();
            obj["command"] = "response";
            obj["type"] = "register";
            obj["data"] = "registered";
            List<TV> TVs = db.TVs.Where(s => s.IP == ip).ToList();
            if (TVs.Count() == 0)
            {
                TV New = new TV();
                New.IP = EP.Address.ToString();
                db.TVs.Add(New);
                obj["data"] = "TV Added";
                db.SaveChanges();
            }
            else
            {
                TVs = db.TVs.Where(s => s.IP == ip && s.registered == true).ToList();
                if (TVs.Count() == 0)
                    obj["data"] = "Not registered";
            }
            sendMessage(obj.ToString(),EP);
        }
        private void complateRegister(JObject MSG, IPEndPoint EP)
        {
            string ip = EP.Address.ToString();
            db.TVs.Where(s => s.IP == ip).ToList().ForEach((s) => {
                s.MAC = (string)MSG["mac"];
                s.SubnetMask = (string)MSG["netmask"];
                s.Getway = (string)MSG["gateway"];
                s.DNS = (string)MSG["primaryDns"];
                });
            db.SaveChanges();
        }
        public async void tvTime(JObject MSG, IPEndPoint EP)
        {
            JObject obj = new JObject();
            obj["command"] = "response";
            if ((string)MSG["type"] == "get")
            {
                obj["type"] = "setTime";
                obj["data"] = DateTime.Now.ToString();
            }
            sendMessage(obj.ToString(),EP);
        }
        

        private void main_Load_1(object sender, EventArgs e)
        {
            this.tVsTableAdapter.Fill(this.dbUdpHTVDataSet.TVs);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[10].ReadOnly = true;

           
            try
            {
                CheckForIllegalCrossThreadCalls = false;

                //We are using UDP sockets
                serverSocket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Dgram, ProtocolType.Udp);

                //Assign the any IP of the machine and listen on port number 54321
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 54321);

                //Bind this address to the server
                serverSocket.Bind(ipEndPoint);

                IPEndPoint ipeSender = new IPEndPoint(IPAddress.Any, 0);
                //The epSender identifies the incoming clients
                EndPoint epSender = (EndPoint)ipeSender;

                //Start receiving data
                byteData = new byte[1024];
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length,
                    SocketFlags.None, ref epSender, new AsyncCallback(OnReceive), epSender);
                
            }
            catch (Exception ex)
            {

                listBoxLog.Items.Add("000.00.00.000 - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": main_Load Exception " + ex.Message);
                // MessageBox.Show(ex.Message, "MRK Server UDP Ex",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OnReceive(IAsyncResult ar)
        {
            string log = "";
            IPEndPoint ipeSender = new IPEndPoint(IPAddress.Any, sendPort);
            EndPoint epSender = ipeSender;
            try
            {
               
                serverSocket.EndReceiveFrom(ar, ref epSender);
                ipeSender = (IPEndPoint)epSender;
                ipeSender.Port = sendPort;
                epSender = (EndPoint)(ipeSender);
                string reciveMSG = Encoding.ASCII.GetString(byteData).Replace("\0","").Replace("\r\n","");
                reciveMSG = reciveMSG.Substring(1, reciveMSG.Length - 2).Replace("\\","") ;
                log = ipeSender.Address.ToString() + " - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": " + reciveMSG;
                listBoxLog.Items.Add(log);
                reciveMSG = JsonConvert.DeserializeObject(reciveMSG).ToString();
                HandelMessage(reciveMSG, ipeSender);
                byteData = new byte[1024];
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epSender, new AsyncCallback(OnReceive), epSender);
                string path = "log/" + DateTime.Now.ToString("yyyy/MM/dd");
                System.IO.Directory.CreateDirectory(path);
                string spcialTV = Path.Combine(path, ipeSender.Address.ToString() + ".txt");
                string allTV = Path.Combine(path, "all.txt");
                try
                {
                    File.AppendAllText(spcialTV, log + Environment.NewLine);
                    File.AppendAllText(allTV, log + Environment.NewLine);
                }
                catch { }
            }
            catch (Exception ex)
            {
                byteData = new byte[1024];
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epSender, new AsyncCallback(OnReceive), epSender);
                string path = "log/" + DateTime.Now.ToString("yyyy/MM/dd");
                System.IO.Directory.CreateDirectory(path);
                string spcialTV = Path.Combine(path, ipeSender.Address.ToString() + ".txt");
                string allTV = Path.Combine(path, "all.txt");
                try
                {
                    File.AppendAllText(spcialTV, log + Environment.NewLine);
                    File.AppendAllText(allTV, log + Environment.NewLine);
                }
                catch { }

                log = ipeSender.Address.ToString() + " - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": OnReceive Exception " + ex.Message;
                listBoxLog.Items.Add(log);
                // MessageBox.Show(ex.Message, "MRK Server UDP Ex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnSend(IAsyncResult ar)
        {
            try
            {
                serverSocket.EndSend(ar);
            }
            catch (Exception ex)
            {

                listBoxLog.Items.Add("000.00.00.000 - " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": OnSend Exception " + ex.Message);
                //MessageBox.Show(ex.Message, "MRK Server UDP Ex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            updateListView();
        }

        private void powerOff_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "powerOff";
                foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
            AutoClosingMessageBox.Show("با موفقیت انجام شد", "اعلان", 1000);
        }

        private void restart_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "reboot";
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
            AutoClosingMessageBox.Show("با موفقیت انجام شد", "اعلان", 1000);
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "response";
            obj["type"] = "setTime";
            obj["data"] = DateTime.Now.ToString();
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
            AutoClosingMessageBox.Show("با موفقیت انجام شد", "اعلان", 1000);
        }

        private void left_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 37;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }
        private void up_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 38;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }
        private void right_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 39;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }
        private void down_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 40;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 13;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "key";
            obj["keyCode"] = 461;
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
        }
        
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            tVsTableAdapter.Fill(dbUdpHTVDataSet.TVs);
            AutoClosingMessageBox.Show("با موفقیت نوسازی شد","اعلان",1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                tVsTableAdapter.Update(dbUdpHTVDataSet.TVs);
            db = new DbUdpHTVEntities();
            AutoClosingMessageBox.Show("با موفقیت نوسازی شد", "اعلان", 1000);
        }

        private void refreshListView()
        {
            listView1.Items.Clear();
            List<TV> TVs = db.TVs.ToList();
            for (int i = 0; i < TVs.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "تلویزیون طبقه: " + TVs[i].Floor + " - شماره: " + TVs[i].RoomNumber + " - شماره IP: " + TVs[i].IP;
                item.Tag = TVs[i];
                listView1.Items.Add(item);
                if (TVs[i].registered == false)
                    listView1.Items[i].BackColor = Color.Gray;
                else if (TVs[i].status == false)
                    listView1.Items[i].BackColor = Color.Red;
                else if (TVs[i].registered == true)
                    listView1.Items[i].BackColor = Color.Green;
            }
        }
        private void updateListView()
        {
            List<TV> TVs = db.TVs.ToList();
            for (int i = 0; i < TVs.Count; i++)
            {
                listView1.Items[i].Text = "تلویزیون طبقه: " + TVs[i].Floor + " - شماره: " + TVs[i].RoomNumber + " - شماره IP: " + TVs[i].IP;
                listView1.Items[i].Tag = TVs[i];
                if (TVs[i].registered == false)
                    listView1.Items[i].BackColor = Color.Gray;
                else if (TVs[i].status == false)
                    listView1.Items[i].BackColor = Color.Red;
                else if (TVs[i].registered == true)
                    listView1.Items[i].BackColor = Color.Green;
            }
        }

        private void getNetworkInformation_Click(object sender, EventArgs e)
        {
            JObject obj = new JObject();
            obj["command"] = "getCurrentNetworkInformation";
            foreach (ListViewItem selecteditem in listView1.SelectedItems)
            {
                TV S = (TV)selecteditem.Tag;
                obj["ip"] = S.IP;
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(S.IP), sendPort);
                sendMessage(obj.ToString(), (IPEndPoint)ipe);
            }
            AutoClosingMessageBox.Show("با موفقیت ارسال شد", "اعلان", 1000);
        }
    }
    
}
