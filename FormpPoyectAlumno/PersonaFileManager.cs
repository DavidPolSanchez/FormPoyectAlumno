using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using log4net.Config;
using log4net;

namespace FormpPoyectAlumno
{
    public class PersonaFileManager : IPersona
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Add(Persona persona)
        {
            log.Info("Accediendo al metodo Add.");
            CreateJsonPersona(persona);
            
        }
        public void CreateJsonPersona(Persona Objpersona)
        {
            log.Info("Accediendo al metodo CreateJsonPersona.");
            string strJsonPerona = JsonConvert.SerializeObject(Objpersona);
            string strJsonPath = @"C:\Users\DSANCHEZ\source\repos\FormpPoyectAlumno\JsonFile\Persona.json";
            generateJson(strJsonPerona, strJsonPath);
        }
        public void generateJson(string strfile, string strPath)
        {
            log.Info("Accediendo al metodo generateJson.");
            if (File.Exists(strPath))
            {
                using (TextWriter JsonFile = new StreamWriter(strPath))
                {
                    JsonFile.WriteLine(strfile);
                    log.Debug("alumno creado correctamente");
                }
            }
            else
            {
                File.Create(strPath).Dispose();
                using (TextWriter JsonFile = new StreamWriter(strPath))
                {
                    JsonFile.WriteLine(strfile);
                    log.Debug("alumno creado correctamente");
                }
            }
        }
    }
}
