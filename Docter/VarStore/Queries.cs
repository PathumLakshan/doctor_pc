using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docter.VarStore
{
    public delegate string query_del(string place, string para = null, string para1 = null, string para2 = null);

    class Queries
    {

        public string queryWithPara(string place, string para = null,string para1=null,string para2=null)
        {
            string returnVal = "";
            switch (place)
            {
                case "PDetails":
                    returnVal = 
                        "select * from Patient_Details where Patient_Name = '" + para + "'";
                    break;
                case "PDforId":
                    returnVal = 
                        "select Patient_Name,Disease,Prescription,Date,Rs from Treatment where Patient_ID = '" + para + "'";
                    break;
                case "PDandTr":
                    returnVal = 
                    "select p.Patient_ID,p.Patient_Name,p.Age,p.P_Number,p.Patient_Gender,p.Patient_NIC,p.P_Address,t.Disease,t.Prescription,t.Date,t.Rs from Patient_Details p, Treatment t where p.Patient_ID = t.Patient_ID and p.Patient_Name = '" + para + "';";
                    break;
                case "PDandTr2":
                    returnVal = 
                        "select p.Patient_ID,p.Patient_Name,p.Age,p.P_Number,p.Patient_Gender,p.Patient_NIC,p.P_Address,t.Disease,t.Prescription,t.Date,t.Rs from Patient_Details p, Treatment t where p.Patient_ID = t.Patient_ID and t.Date between '" + para + "' and '" + para1 + "';";
                    break;
                case "PDandTr3":
                    returnVal =
                     "select p.Patient_ID,p.Patient_Name,p.Age,p.P_Number,p.Patient_Gender,p.Patient_NIC,p.P_Address,t.Disease,t.Prescription,t.Date,t.Rs from Patient_Details p, Treatment t where p.Patient_ID = t.Patient_ID and p.Patient_Name = '" + para + "' and t.Date between '" + para1 + "' and '" + para2 + "';";
                    break;
                case "countPatients":
                    returnVal = 
                        "select count(Patient_ID)  from Patient_Details;";
                    break;
                case "countUsers":
                    returnVal = "select count(UserName) from Login";
                    break;
                case "patientID":
                    returnVal = "Select Patient_ID from Patient_Details where Patient_Name='" + para + "';";
                    break;
                case "treatmentId":
                    returnVal = "select count(Treatment_ID)  from Treatment;"; //k
                    break;
                case "patientname":
                    returnVal = "select Patient_Name from Patient_Details"; //k
                    break;
                case "allpatientdet":
                    returnVal = "select * from Patient_details where Patient_Name = '" + para + "'"; //k
                    break;
                default:
                    Console.Write("shit");
                    break;
            }

            return returnVal;


        }
        
    }
}
