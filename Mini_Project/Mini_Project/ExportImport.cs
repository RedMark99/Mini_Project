using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Mini_Project.MyDbClass;
using Mini_Project.XMLClass;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Mini_Project.SerClass;

namespace Mini_Project
{
    public partial class ExportImport : Form
    {
        public int clientid;
        MyDbContext db = new MyDbContext();
        public ExportImport()
        {
            InitializeComponent();
            Client();
            AddComboxBox();
            CBCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategory.Text = "Все";
        }

        private void BImport_Click(object sender, EventArgs e)
        {
            
                XmlSerialization<CLIENTS> xmlSerialization = new XmlSerialization<CLIENTS>();

                CLIENTS cl = new CLIENTS(); // путь к файлу

                string filePath = @"xml\import.xml";

                cl = (CLIENTS)xmlSerialization.ReadData(filePath, cl); //дерсериализация 

                for (int i = 0; i < cl.CLIENT.Count; i++)
                {
                    string clientName = cl.CLIENT[i].Name;
                    string clientSurname = cl.CLIENT[i].Surname;
                    string clientLastname = cl.CLIENT[i].Lastname;
                    string clientLogin = cl.CLIENT[i].Login;
                    string clientPassword = cl.CLIENT[i].Password;
                    string clientSeriaPassport = cl.CLIENT[i].SeriaPassport;
                    string clientNumberPassport = cl.CLIENT[i].NumberPassport;
                    string clientDateOfBirth = cl.CLIENT[i].DateOfBirth;
                    string clientDesc = cl.CLIENT[i].Deschotel;
                    string clientCountDays = cl.CLIENT[i].CountDaysLive;

                //добавление
                    using (var context = new MyDbContext())
                    {

                        var query = context.Clients.Where(x => x.login == clientLogin || x.numberPassport == clientPassword);

                        var client = new Client()
                        {
                            name = clientName.ToString(),
                            surname = clientSurname.ToString(),
                            lastname = clientLastname.ToString(),
                            login = clientLogin.ToString(),
                            password = clientPassword.ToString(),
                            seriaPassport = clientSeriaPassport.ToString(),
                            numberPassport = clientNumberPassport.ToString(),
                            dataOfBirth = DateTime.Parse(clientDateOfBirth.ToString()),
                            countDaysLive = Convert.ToInt32(clientCountDays),
                            deschotel = clientDesc.ToString()
                        };

                        if (query.ToList().Count < 1)
                        {
                            context.Clients.Add(client);
                            context.SaveChanges();
                        }

                        
                    }



                    for (int j = 0; j < cl.CLIENT[i].HOTELROOM.Count; j++) 
                    {

                        string hotelNomer = cl.CLIENT[i].HOTELROOM[j].Nomer;
                        string hotelCountPeople = cl.CLIENT[i].HOTELROOM[j].CountPeople;
                        string hotelCategory = cl.CLIENT[i].HOTELROOM[j].Category;
                        string hotelPayment = cl.CLIENT[i].HOTELROOM[j].Payment;

                        using (var context = new MyDbContext())
                        {
                            
                            var query = context.HotelRooms.Where(x => x.nomer == hotelNomer);

                            var hotelRoom = new HotelRoom()
                            {
                                nomer = hotelNomer,
                                countPeople = Convert.ToInt32(hotelCountPeople),
                                category = hotelCategory,
                                payment = Convert.ToInt32(hotelPayment)
                            };

                            if (query.ToList().Count < 1)
                            {
                                context.HotelRooms.Add(hotelRoom);
                                context.SaveChanges();
                            }
                        }
                        

                        for (int y = 0; y < cl.CLIENT[i].HOTELROOM[j].REGHOTELS.Count; y++) 
                        {
                            
                            
                            string regStartlive = cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].StartLive.ToString();
                            string regEndLive = cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].EndLive.ToString();
                            string regDescLive = cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].Desclive.ToString();

                            using (var context = new MyDbContext())
                            {
                                
                               


                                var idFlat = context.HotelRooms.Where(x => x.nomer == hotelNomer).Select(x => x.idFlat).First();


                                //var idFlat = from x in context.HotelRooms
                                //             where x.nomer.ToString() == cl.CLIENT[i].HOTELROOM[j].Nomer.ToString()
                                //             select x.idFlat;

                                //foreach (var x in idFlat.ToList())
                                //{
                                //    idFlats = x;
                                //}

                                var idClient = context.Clients.Where(x => x.name == clientName && x.surname == clientSurname && x.lastname == clientLastname && x.seriaPassport == clientSeriaPassport && x.numberPassport == clientNumberPassport && x.login == clientLogin && x.password == clientPassword).Select(x => x.idClient).First();

                                //var idClient = from x in context.Clients
                                //                   where x.name.ToString() == cl.CLIENT[i].Name.ToString() && x.surname.ToString() == cl.CLIENT[i].Surname.ToString() && x.lastname.ToString() == cl.CLIENT[i].Lastname.ToString() && x.seriaPassport.ToString() == cl.CLIENT[i].SeriaPassport.ToString() && x.numberPassport.ToString() == cl.CLIENT[i].NumberPassport.ToString() && x.login.ToString() == cl.CLIENT[i].Login.ToString() && x.password.ToString() == cl.CLIENT[i].Password.ToString()
                                //                   select x.idClient;

                                //foreach (var x in idClient.ToList())
                                //{
                                //    idClients = x;
                                //}

                                int idFlatTest = Convert.ToInt32(idFlat);
                                DateTime RS = DateTime.Parse(DateTime.Parse(regStartlive).ToShortDateString().ToString());
                                DateTime RE = DateTime.Parse(DateTime.Parse(regEndLive).ToShortDateString().ToString());



                                var query = context.RegHotels.Where(x => x.idFlat == idFlatTest && (RS >= x.startLive && x.endLive >= RS || RE >= x.startLive && x.endLive >= RE));

                                if (query.ToList().Count > 0)
                                {
                                    MessageBox.Show("Это дата уже занята");
                                }

                                else 
                                { 
                                    var regHotel = new RegHotel()
                                    {
                                        idFlat = Convert.ToInt32(idFlat),
                                        idClient = Convert.ToInt32(idClient),
                                        startLive = DateTime.Parse(cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].StartLive.ToString()),
                                        endLive = DateTime.Parse(cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].EndLive.ToString()),
                                        desclive = cl.CLIENT[i].HOTELROOM[j].REGHOTELS[y].Desclive
                                    };

                                    context.RegHotels.Add(regHotel);
                                    context.SaveChanges();
                                }
                            }
                            
                        }
                    }
                }
            MessageBox.Show("Импорт завершён");
            
        }

        private void TBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridView.CurrentCell.RowIndex;

            clientid = Convert.ToInt32(dataGridView.Rows[indexRow].Cells[0].Value);
        }

        public void AddComboxBox()
        {
            CBCategory.Items.Add("Люкс");
            CBCategory.Items.Add("Полулюкс");
            CBCategory.Items.Add("Обычный");
            CBCategory.Items.Add("Все");
        }

        //Client --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
        public void Client()
        {
            dataGridView.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridView.SelectAll();
            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();




            //Создаём заранее колонки
            dataGridView.Columns.Add("Column0", "ID Клиента");
            dataGridView.Columns.Add("Column1", "Имя");
            dataGridView.Columns.Add("Column2", "Фамилия");
            dataGridView.Columns.Add("Column3", "Отчество");
            dataGridView.Columns.Add("Column4", "Дата рождения");
            dataGridView.Columns.Add("Column5", "Серия паспорта");
            dataGridView.Columns.Add("Column6", "Номер паспорта");
            dataGridView.Columns.Add("Column7", "Кол-во дней прожитых");

            //Подключение к базе данных MicroSoft Sql server
            using (var context = new MyDbContext())
            {
                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                var res = from x in context.Clients
                          select new
                          {
                              Id = x.idClient,
                              Name = x.name,
                              Surname = x.surname,
                              Lastname = x.lastname,
                              dateOfBirth = x.dataOfBirth,
                              seriapassport = x.seriaPassport,
                              nomerpassport = x.numberPassport,
                              countlive = x.countDaysLive
                          };
                //Считываем в datagrid view
                foreach (var item in res.ToList())
                {
                    dataGridView.Rows.Add(item.Id, item.Name, item.Surname, item.Lastname, item.dateOfBirth, item.seriapassport, item.nomerpassport, item.countlive);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

                //Код для полного заполнения базы данных
                //BindingSource dbclient = new BindingSource();
                //dbclient.DataSource = typeof(Client);
                //context.Clients.ToList().ForEach(x => dbclient.Add(x));
                //dataGridView.DataSource = dbclient;
            }
        }
        //Client --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //

        private void ExportImport_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void BExportplease_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var clients = context.Clients.ToList();

                var wasreg = new List<RegTest>();

                var wasnomer = new List<string>();

                int countCBCategory;
                string nomername = "0";

                if (clientid > 0)
                {
                    clients = context.Clients.Where(x => x.idClient == clientid).ToList();
                }

                int key = 0;
                XDocument doc = new XDocument(new XElement("CLIENTS"));
                for (int i = 0; i < clients.Count(); i++)
                {
                    wasnomer.Clear();

                    doc.Element("CLIENTS").Add(new XElement("CLIENT",
                        new XElement("name", clients[i].name.Trim()),
                        new XElement("surname", clients[i].surname.Trim()),
                        new XElement("lastname", clients[i].lastname.Trim()),
                        new XElement("login", clients[i].login.Trim()),
                        new XElement("password", clients[i].password.Trim()),
                        new XElement("seriaPassport", clients[i].seriaPassport.Trim()),
                        new XElement("numberPassport", clients[i].numberPassport.Trim()),
                        new XElement("deschotel", clients[i].deschotel.Trim()),
                        new XElement("countDaysLive", clients[i].countDaysLive.ToString().Trim()),
                        new XElement("dateOfBirth", clients[i].dataOfBirth.ToString().Trim()))
                        );

                    var regHotels = context.RegHotels.ToList();

                    foreach(var regHotel in regHotels) 
                    {
                        wasreg.Clear();
                        if (clients[i].idClient == regHotel.idClient)
                        {
                            var hotelRooms = context.HotelRooms.ToList();


                            if (CBCategory.SelectedItem.ToString() != "Все")
                            {
                                //hotelRooms = context.HotelRooms.Where(x => x.category == CBCategory.SelectedItem.ToString() && x.idFlat == regHotel.idFlat).ToList();
                                hotelRooms = context.HotelRooms.Where(x => x.category == CBCategory.SelectedItem.ToString()).ToList();
                            }
                            if (TBCount.Text != "")
                            {
                                //hotelRooms = context.HotelRooms.Where(x => x.idFlat == regHotel.idFlat && TBCount.Text == x.countPeople.ToString()).ToList();
                                hotelRooms = context.HotelRooms.Where(x => TBCount.Text == x.countPeople.ToString()).ToList();
                            }
                            if (CBCategory.SelectedItem.ToString() != "Все" && TBCount.Text != "") 
                            {
                                hotelRooms = context.HotelRooms.Where(x => x.category == CBCategory.SelectedItem.ToString() && TBCount.Text == x.countPeople.ToString()).ToList();
                            }

                            foreach(var hotelRoom in hotelRooms) 
                            {
                                bool check = false;

                                foreach(var s in wasnomer) 
                                {
                                    if (hotelRoom.nomer.ToString() == s) 
                                    {
                                        check = true;   
                                    }
                                    nomername = hotelRooms.Where(x => x.idFlat == hotelRoom.idFlat).Select(x => x.nomer).First().Trim().ToString();
                                }

                                

                                if (check == false)
                                {
                                    wasnomer.Add(hotelRoom.nomer);

                                    var HotelRoomXML = new XElement("HOTELROOM",
                                        new XElement("nomer", hotelRoom.nomer.Trim()),
                                        new XElement("countPeople", hotelRoom.countPeople.ToString().Trim()),
                                        new XElement("category", hotelRoom.category.Trim()),
                                        new XElement("payment", hotelRoom.payment.ToString().Trim())
                                        );

                                    var ourClient = doc.Descendants("CLIENT")
                                    .Where(x => x.Element("name")
                                    .Value.Equals(clients[i].name.Trim())).FirstOrDefault();

                                    nomername = hotelRooms.Where(x => x.idFlat == hotelRoom.idFlat).Select(x => x.nomer).First().Trim().ToString();

                                    if (ourClient != null) 
                                    {
                                        if (!ourClient.Elements("CLIENTS").Any())
                                            ourClient.Add(new XElement("CLIENTS"));

                                        bool duplicatePatient = false;
                                            foreach (var elem in ourClient.Element("CLIENTS").Elements("HOTELROOM"))
                                            {
                                                duplicatePatient = XNode.DeepEquals(elem, HotelRoomXML);
                                                if (duplicatePatient)
                                                    break;
                                            }

                                            if (!duplicatePatient)
                                            {
                                                ourClient.Add(HotelRoomXML);
                                            }
                                    }

                                }
                                if (clients[i].idClient == regHotel.idClient) 
                                {
                                    bool checkss = false;
                                    bool let = false;


                                    foreach (var s in wasreg)
                                    {
                                        DateTime dateStart = DateTime.Parse(s.StartLive);
                                        DateTime dateEnd = DateTime.Parse(s.EndLive);
                                        string descs = s.Desclive;

                                        int idClientMark = clients[i].idClient;
                                        int idFlatMark = hotelRoom.idFlat;

                                        var querys = context.RegHotels.Where(x => x.idClient == idClientMark && x.idFlat == idFlatMark && x.startLive == dateStart && x.endLive == dateEnd && x.desclive == descs);

                                        if (querys.ToList().Count() < 1)
                                        {
                                            checkss = true;
                                        }

                                        if (s.idClient == clients[i].idClient && s.idFlat == hotelRoom.idFlat && s.StartLive == dateStart.ToString() && s.EndLive == dateEnd.ToString() && s.Desclive == descs)
                                        {
                                            checkss = true;
                                        }
                                    }

                                    int idClientMark1 = clients[i].idClient;
                                    int idFlatMark1 = hotelRoom.idFlat;
                                    DateTime dateStart1 = regHotel.startLive;
                                    DateTime dateEnd1 = regHotel.endLive;
                                    string descs1 = regHotel.desclive;

                                    var hotelRoomCheck = context.RegHotels.Where(x => x.idFlat == idFlatMark1 && x.idClient == idClientMark1 && x.startLive == dateStart1 && x.endLive == dateEnd1 && x.desclive == descs1);

                                    if (hotelRoomCheck.ToList().Count() > 0)
                                    {
                                        let = true;
                                    }

                                    if (checkss == false && let == true) 
                                    {
                                        nomername = hotelRooms.Where(x => x.idFlat == hotelRoom.idFlat).Select(x => x.nomer).First().Trim().ToString();
                                        wasreg.Add(new RegTest(clients[i].idClient, hotelRoom.idFlat, regHotel.startLive.ToString("dd.MM.yyyy"), regHotel.endLive.ToString("dd.MM.yyyy"), regHotel.desclive));

                                        var regHotelXml = new XElement("REGHOTELS",
                                            new XElement("startLive", regHotel.startLive.ToString("dd.MM.yyyy").Trim()),
                                            new XElement("endLive", regHotel.endLive.ToString("dd.MM.yyyy").Trim()),
                                            new XElement("desclive", regHotel.desclive.ToString().Trim())
                                            );

                                        var ourRegHotel = doc.Descendants("CLIENT")
                                            .Where(x => x.Element("name")
                                            .Value.Equals(clients[i].name.Trim())).FirstOrDefault().Descendants("HOTELROOM")
                                            .Where(x => x.Element("nomer")
                                            .Value.Equals(nomername)).FirstOrDefault();

                                        if(ourRegHotel != null) 
                                        {
                                            ourRegHotel.Add(regHotelXml);
                                        }
                                    }

                                }
                                

                            }

                        }
                    }
                    key++;
                }
                string filePath = @"xml\export.xml";
                doc.Save(filePath);

                MessageBox.Show("Экспорт завершен !");
            }
        }
    }
}
