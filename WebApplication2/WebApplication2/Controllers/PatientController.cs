using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;


namespace WebApplication2.Controllers
{
    public class PatientController : ApiController
    {
        Patient[] Patients = new Patient[]
        {
            new Patient { bleID = 0, BP_High = 120, BP_Low = 80, currentPatient = false,
                          history = "Patient presents with shortness of breath and dizzyness", id = 0, name = "John Doe", O2Sat = 95, Pulse = 50, age = 24, height = 72, sex = "male", weight = 74},
            new Patient { bleID = 1, BP_High = 125, BP_Low = 90, currentPatient = true,
                          history = "Patient complained of chest pain.  Cards ruled out MI", id = 1, name = "Jane Doe", O2Sat = 99, Pulse = 52, age = 24, height = 66, sex = "female", weight = 50},
        };

        public int currentPatient = 0;

        [Route("api/set_patient/{patientID}")]
        [HttpPut]
        public IHttpActionResult SetCurrentPatient(int patientID)
        {
            Patient[] patients = DeserializeProducts();
            currentPatient = patientID;
            var patient = patients.FirstOrDefault((p) => p.id == currentPatient);
            if (patient == null)
            {
                return NotFound();
            }
            patient.currentPatient = true;
            var patient2 = patients.FirstOrDefault((p) => p.id != currentPatient);
            if(patient2 != null)
            {
                patient2.currentPatient = false;
            }
            SerializeProducts(patient, patient2);
            return Ok(currentPatient);
        }

        [Route("instrument/{bp_high}/{bp_low}/{pulse}/{o2sat}")]
        [HttpPut]
        public IHttpActionResult SetCurrentVitals(int bp_high, int bp_low, int pulse, int o2sat)
        {
            Patient[] patients = DeserializeProducts();
            var patient = patients.FirstOrDefault((p) => p.currentPatient == true);
            if (patient == null)
            {
                return NotFound();
            }
            var patient2 = patients.FirstOrDefault((p) => p.currentPatient == false);
            if (patient == null)
            {
                return NotFound();
            }
            patient.O2Sat = o2sat;
            patient.Pulse = pulse;
            patient.BP_High = bp_high;
            patient.BP_Low = bp_low;
            Patients[patient.id] = patient;
            SerializeProducts(patient, patient2);
            return Ok();
        }

        [Route("api/get_patient")]
        public IHttpActionResult GetCurrentPatient()
        {
            Patient[] patients = DeserializeProducts();
            var patient = patients.FirstOrDefault((p) => p.currentPatient == true);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            Patient[] patients = DeserializeProducts();
            return patients;
        }

        public IHttpActionResult GetPatient(int id)
        {
           Patient[] patients =  DeserializeProducts();
           var patient = patients.FirstOrDefault((p) => p.id == id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        private void SerializeProducts(Patient pat, Patient pat2)
        {
             XmlSerializer serializer = new XmlSerializer(typeof(Patient));
            MemoryStream stream1 = new MemoryStream();
             using (TextWriter writer = new StreamWriter(@"C:\Users\Jon\Documents\Visual Studio 2013\Projects\WebApplication2\WebApplication2\App_Data\Patient0.xml"))
              {
                serializer.Serialize(writer, pat);
                writer.Close();
                  //serializer.Serialize(stream1, Patients[0]);
              }
            
             using (TextWriter writer = new StreamWriter(@"C:\Users\Jon\Documents\Visual Studio 2013\Projects\WebApplication2\WebApplication2\App_Data\Patient1.xml"))
              {
                  serializer.Serialize(writer, pat2);
                  writer.Close();
              }
            
            
        }

        private Patient[] DeserializeProducts()
        {
            Patient[] patients = new Patient[] {
                new Patient(),
                new Patient(),
            };
            XmlSerializer deserializer = new XmlSerializer(typeof(Patient));
            TextReader reader = new StreamReader(@"C:\Users\Jon\Documents\Visual Studio 2013\Projects\WebApplication2\WebApplication2\App_Data\Patient0.xml");
            object obj = deserializer.Deserialize(reader);
            patients[0] = (Patient)obj;
            reader.Close();
            TextReader reader1 = new StreamReader(@"C:\Users\Jon\Documents\Visual Studio 2013\Projects\WebApplication2\WebApplication2\App_Data\Patient1.xml");
            object obj1 = deserializer.Deserialize(reader1);
            patients[1] = (Patient)obj1;
            reader1.Close();
            return patients;
        }

    }
}
