using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPASM
{
    public partial class Form1 : Form
    {

        List<string> listINI = new List<string>();
        List<string> listSocials = new List<string>();
        List<string> listSourceSocials = new List<string>();

        List<Social> currentsocials = new List<Social>();
        //Social social = new Social();
        List<Social> sourcesocials = new List<Social>();


        public Form1()
        {
            InitializeComponent();
        }


        private void btnGetEQ_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();

            txtGetEQ.Text = folderBrowserDialog1.SelectedPath;

        }


        private void btnGetINIs_Click(object sender, EventArgs e)
        {

            // Look for INI files in the EQ folder, and populate listINI collection

            //statusStrip1.Items

            toolStripStatusLabel1.Text = "Loading INI files...";

            listINI.Clear();


            string[] allfiles = Directory.GetFiles(txtGetEQ.Text, "*_*_*.ini", SearchOption.TopDirectoryOnly);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);


                if (!info.Name.StartsWith("BZR_")       // ignore bazaar ini files
                    && !info.Name.StartsWith("UI_"))    // ignore UI ini files
                {

                    listINI.Add(info.Name);
                   

                }
            }

            listINI.Sort();


            // Display in text box and populate combobox

            txtINIs.Clear();
            cboCurrentCharacter.Items.Clear();
            cboSource.Items.Clear();

            foreach (string item in listINI)
            {
                txtINIs.AppendText(item.ToString());
                txtINIs.AppendText(Environment.NewLine);

                cboCurrentCharacter.Items.Add(item.ToString());
                cboSource.Items.Add(item.ToString());

                if (cboCurrentCharacter.Text.Equals(""))        // set text if blank
                {
                    cboCurrentCharacter.Text = item.ToString();
                }

                if (cboSource.Text.Equals("") && !item.ToString().Equals(cboCurrentCharacter.Text))
                {
                    cboSource.Text = item.ToString();
                }

            }

            toolStripStatusLabel1.Text = "INI files loaded.";


        }



        private void btnGetSocials_Click(object sender, EventArgs e)
        {
            // C:\temp\SPASM\Nostrill_antonius_CLR.ini

            // open ini file and extract the Socials stanza
            // PageXButtonYAttribute=zzz
            // e.g.
            //  Page2Button1Name=assist
            //  Page2Button1Color=0
            //  Page2Button1Line1=/assist
            //  Page2Button10Name=Rezzing
            //  Page2Button10Color=0

            toolStripStatusLabel1.Text = "Loading Socials from INI files...";


            // do nothing if no INI file selected
            if (cboCurrentCharacter.Text.Equals(""))
            {
                return;
            }

            listSocials.Clear();
            txtSocials.Clear();
            currentsocials.Clear();
            lstCurrent.Items.Clear();


            //StreamReader sr = new StreamReader("C:\\temp\\SPASM\\Nostrill_antonius_CLR.ini");
            StreamReader sr = new StreamReader(txtGetEQ.Text + "\\" + cboCurrentCharacter.Text.ToString());
            string line = sr.ReadLine();

            while (line != null && !line.Equals("[Socials]")) // read through until we get to Socials stanza
            {
                line = sr.ReadLine();
            }

            // in [Socials]
            line = sr.ReadLine();

            while (line != null && line.StartsWith("Page")) // read through Page entries until null or not a Page entry
            {
                listSocials.Add(line.ToString());
                line = sr.ReadLine();
            }

            //listSociala.Sort();
            listSocials.Sort(CompareSocials);


            // Add socials into socials list

            Social soc = new Social();

            foreach (string s in listSocials)
            {

                if (soc.location == "")
                {
                    // new object, populate ini filename and location
                    soc.location = getlinelocation(s);
                    soc.ini = txtGetEQ.Text + "\\" + cboCurrentCharacter.Text.ToString();
                    soc.filename = cboCurrentCharacter.Text.ToString();
                }

                if (getlinelocation(s) != soc.location)
                {
                    // add the current soc to the collection and start a new soc object
                    currentsocials.Add(soc);
                    soc = new Social();

                }
                // add the current line to current soc
                // TODO
                switch (getlinetype(s))
                {
                    case "Name":
                        soc.Name = getlinevalue(s);
                        break;

                    case "Color":
                        soc.Color = Int32.Parse(getlinevalue(s));
                        break;

                    case "Line1":
                        soc.Line1 = getlinevalue(s);
                        break;

                    case "Line2":
                        soc.Line2 = getlinevalue(s);
                        break;

                    case "Line3":
                        soc.Line3 = getlinevalue(s);
                        break;

                    case "Line4":
                        soc.Line4 = getlinevalue(s);
                        break;

                    case "Line5":
                        soc.Line5 = getlinevalue(s);
                        break;
                }


            }
            currentsocials.Add(soc);  // save the final soc obkect


            /*
                foreach (string s in listSocials)
            {
                // DEBUG - check extraction
                txtSocials.AppendText(s.ToString());
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(getlineshort(s));
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(getlinelocation(s));
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(getlinetype(s));
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(getlinevalue(s));
                txtSocials.AppendText(Environment.NewLine);
            }
            */


            // populate textbox

            /*
            foreach (string item in listSocials)
            {
                txtSocials.AppendText(item.ToString());
                txtSocials.AppendText(Environment.NewLine);
            }
            */

            // populate textbox from Social collection
            foreach (Social soc2 in currentsocials)
            {
                txtSocials.AppendText("ObjectStart");
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(soc2.ini);
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(soc2.location);
                txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText(soc2.Name);
                txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Color.ToString());
                //txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Line1);
                //txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Line2);
                //txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Line3);
                //txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Line4);
                //txtSocials.AppendText(Environment.NewLine);
                //txtSocials.AppendText(soc2.Line5);
                //txtSocials.AppendText(Environment.NewLine);
                txtSocials.AppendText("ObjectEnd");
                txtSocials.AppendText(Environment.NewLine);

                lstCurrent.Items.Add(soc2);

            }


            /* DEBUG
            foreach (Social soc2 in  currentsocials)
            {
                Debug.WriteLine("ObjectStart");
                Debug.WriteLine(soc2.ini);
                Debug.WriteLine(soc2.location);
                Debug.WriteLine(soc2.Name);
                Debug.WriteLine(soc2.Color);
                Debug.WriteLine(soc2.Line1);
                Debug.WriteLine(soc2.Line2);
                Debug.WriteLine(soc2.Line3);
                Debug.WriteLine(soc2.Line4);
                Debug.WriteLine(soc2.Line5);
                Debug.WriteLine("ObjectEnd");
            }
            */



            // now do same for the source char
            if (cboSource.Text.Equals(""))
            {
                return;
            }

            listSourceSocials.Clear();
            txtAllSocials.Clear();
            sourcesocials.Clear();
            lstAllSocials.Items.Clear();

            //StreamReader sr = new StreamReader("C:\\temp\\SPASM\\Nostrill_antonius_CLR.ini");
            StreamReader srSource = new StreamReader(txtGetEQ.Text + "\\" + cboSource.Text.ToString());
            line = srSource.ReadLine();

            while (line != null && !line.Equals("[Socials]")) // read through until we get to Socials stanza
            {
                line = srSource.ReadLine();
            }

            // in [Socials]
            line = srSource.ReadLine();

            while (line != null && line.StartsWith("Page")) // read through Page entries until null or not a Page entry
            {
                listSourceSocials.Add(line.ToString());
                line = srSource.ReadLine();
            }

            //listSociala.Sort();
            listSourceSocials.Sort(CompareSocials);

            // Add socials into socials list

            soc = new Social();

            foreach (string s in listSourceSocials)
            {

                if (soc.location == "")
                {
                    // new object, populate ini filename and location
                    soc.location = getlinelocation(s);
                    soc.ini = txtGetEQ.Text + "\\" + cboSource.Text.ToString();
                    soc.filename = cboSource.Text.ToString();

                }

                if (getlinelocation(s) != soc.location)
                {
                    // add the current soc to the collection and start a new soc object
                    sourcesocials.Add(soc);
                    soc = new Social();

                }
                // add the current line to current soc
                // TODO
                switch (getlinetype(s))
                {
                    case "Name":
                        soc.Name = getlinevalue(s);
                        break;

                    case "Color":
                        soc.Color = Int32.Parse(getlinevalue(s));
                        break;

                    case "Line1":
                        soc.Line1 = getlinevalue(s);
                        break;

                    case "Line2":
                        soc.Line2 = getlinevalue(s);
                        break;

                    case "Line3":
                        soc.Line3 = getlinevalue(s);
                        break;

                    case "Line4":
                        soc.Line4 = getlinevalue(s);
                        break;

                    case "Line5":
                        soc.Line5 = getlinevalue(s);
                        break;
                }


            }
            sourcesocials.Add(soc);  // save the final soc obkect



            // populate textbox from Social collection
            foreach (Social soc2 in sourcesocials)
            {
                txtAllSocials.AppendText("ObjectStart");
                txtAllSocials.AppendText(Environment.NewLine);
                txtAllSocials.AppendText(soc2.ini);
                txtAllSocials.AppendText(Environment.NewLine);
                txtAllSocials.AppendText(soc2.location);
                txtAllSocials.AppendText(Environment.NewLine);
                txtAllSocials.AppendText(soc2.Name);
                txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Color.ToString());
                //txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Line1);
                //txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Line2);
                //txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Line3);
                //txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Line4);
                //txtAllSocials.AppendText(Environment.NewLine);
                //txtAllSocials.AppendText(soc2.Line5);
                //txtAllSocials.AppendText(Environment.NewLine);
                txtAllSocials.AppendText("ObjectEnd");
                txtAllSocials.AppendText(Environment.NewLine);

                lstAllSocials.Items.Add(soc2);
            }


            /*
            // populate textbox

            foreach (string item in listSourceSocials)
            {
                txtAllSocials.AppendText(item.ToString());
                txtAllSocials.AppendText(Environment.NewLine);
            }
            */



            toolStripStatusLabel1.Text = "Socials loaded from INI files.";



        }


        private static int CompareSocials(string x, string y)
        {
            // Compare two Socials lines
            // 
            // Page2Button10Name=Rezzing
            // 
            // Need to consider only the first part of the string, ignoring everything from the equals sign onwards
            // then use the order Name, LineX, then any other attributes

            // preserve original values
            string xOrig = x;
            string yOrig = y;


            // look for the equals sign and truncate strings
            //int xEquals = x.IndexOf("=");
            //x = x.Substring(0, xEquals);
            x = getlineshort(x);

            //int yEquals = y.IndexOf("=");
            //y = y.Substring(0, yEquals);
            y = getlineshort(y);

            // preserve truncated original values
            string xOrigShort = x;
            string yOrigShort = y;


            // now compare the PageXButtonY part
            // work backwards through strings until a number is reached



            int number;  // ignored value returned by TryParse


            x = x.Substring(0, x.Length - 1);        // lop a char off the end, to account for LineX

            int xLen = x.Length;
            string xLastChar = x.Substring(xLen - 1);

            while (Int32.TryParse(xLastChar, out number) != true)
            {
                x = x.Substring(0, x.Length - 1);        // lop a char off the end
                xLastChar = x.Substring(x.Length - 1);      // grab new last char

            }




            y = y.Substring(0, y.Length - 1);        // lop a char off the end, to account for LineX

            int yLen = y.Length;
            string yLastChar = y.Substring(yLen - 1);

            while (Int32.TryParse(yLastChar, out number) != true)
            {
                y = y.Substring(0, y.Length - 1);        // lop a char off the end
                yLastChar = y.Substring(y.Length - 1);      // grab new last char

            }


            // noW have two strings containing just the Page and Button numbers

            if (!x.Equals(y))
            {
                // Page/Button different, so return the normal comparison
                return x.CompareTo(y);
            }

            // here, the two lines are same page, same button, so need to look at the attribute

            string xAttribute = xOrigShort.Substring(x.Length);
            string yAttribute = yOrigShort.Substring(y.Length);

            if (xAttribute.Equals("Name") || yAttribute.Equals("Color"))
            {
                return -1;  // x is first
            }

            if (yAttribute.Equals("Name") || xAttribute.Equals("Color"))
            {
                return 1;  // x is last
            }


            /*
            if (xAttribute.Equals("Color"))
            {
                return 1;  // x is last
            }

            if (yAttribute.Equals("Color"))
            {
                return -1;  // x is first
            }
            */



            int retval = xAttribute.CompareTo(yAttribute);

            return retval;

            //return x.CompareTo(y);







        }



        public static string getlinelocation(string s)
        {
            // given a line from a social, extract the location PageXButtonY

            string linetype = getlinetype(s);
            int typeposition = s.IndexOf(linetype);

            return s.Substring(0, typeposition);


        }

        public static string getlinetype(string s)
        {
            // given a line from a social, extract the type: Name, Color, LineX

            string sshort = getlineshort(s);

            int txtindex = 0;

            txtindex = sshort.IndexOf("Name");
            if (txtindex > 0)
            {
                return "Name";
            }

            txtindex = sshort.IndexOf("Color");
            if (txtindex > 0)
            {
                return "Color";
            }

            txtindex = sshort.IndexOf("Line");
            if (txtindex > 0)
            {
                return sshort.Substring(txtindex, sshort.Length - txtindex);
            }


            return "Unknown";

        }


        public static string getlinevalue(string s)
        {
            // given a line from a social, return the value
            int xEquals = s.IndexOf("=");
            s = s.Substring(xEquals + 1, s.Length - xEquals - 1);

            return s;

        }


        public static string getlineshort(string s)
        {
            // given a line from a social, extract the part before the Equals
            int xEquals = s.IndexOf("=");
            s = s.Substring(0, xEquals);

            return s;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Select the folder where EverQuest is installed.";
        }

        private void lstCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scoail selected, display contents

            Social soc = lstCurrent.SelectedItem as Social;

            txtCurrentName.Text = soc.Name;
            txtcurrentLine1.Text = soc.Line1;
            txtcurrentLine2.Text = soc.Line2;
            txtcurrentLine3.Text = soc.Line3;
            txtcurrentLine4.Text = soc.Line4;
            txtcurrentLine5.Text = soc.Line5;
            txtcurrentColor.Text = soc.Color.ToString();


        }

        private void lstAllSocials_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scoail selected, display contents

            Social soc = lstAllSocials.SelectedItem as Social;

            txtAllName.Text = soc.Name;
            txtAllLine1.Text = soc.Line1;
            txtAllLine2.Text = soc.Line2;
            txtAllLine3.Text = soc.Line3;
            txtAllLine4.Text = soc.Line4;
            txtAllLine5.Text = soc.Line5;
            txtAllColor.Text = soc.Color.ToString();
        }

   
    }


    class Social
    {
        public string ini = "";        // ini this came from, uncluding path
        public string filename = "";
        public string location = "";   // PageXButtonY

        public string Name = "";       // macro settings
        public int Color = 0;
        public string Line1 = "";
        public string Line2 = "";
        public string Line3 = "";
        public string Line4 = "";
        public string Line5 = "";


        public override string ToString()
        {
            return filename + "\\" + Name;
        }

    }


}
