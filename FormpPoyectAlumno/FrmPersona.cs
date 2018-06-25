using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace FormpPoyectAlumno
{
   
    public partial class FrmDatos : Form
    {
       
        public FrmDatos()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Persona person = new Persona
            {
                intId = Convert.ToInt32(txtId.Text),
                StrName = txtName.Text,
                StrSurname = txtSurname.Text,
                strDNI = txtDNI.Text
            };

            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtDNI.Clear();
            CreateJsonPersona(person);
        }
        public void CreateJsonPersona(Persona Objperson)
        {
            string strJsonPerona = JsonConvert.SerializeObject(Objperson);
            string strJsonPath = @"C:\Users\DSANCHEZ\source\repos\FormpPoyectAlumno\JsonFile\Persona.json";
            generateJson(strJsonPerona, strJsonPath);
        }
        private void generateJson( string strfile,string strPath)
        {
            if (File.Exists(strPath))
            {
                using (TextWriter JsonFile = new StreamWriter(strPath))
                {
                    JsonFile.WriteLine(strfile);
                }
            }
            else
            {
                File.Create(strPath).Dispose();
                using (TextWriter JsonFile = new StreamWriter(strPath))
                {
                    JsonFile.WriteLine(strfile);
                }
            }
        }
    }
}
