using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PSI_CNP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int patientID = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            int points;

            String age = txtAge.Text;
            int ageNum = Convert.ToInt32(age);

            String sex = "";
            int pointsSex = 0;

            int nursinghomeRes = 0;
            int pointsNursingHomeRes = 0;

            int nd = 0;
            int pointsnd = 0;

            int ld = 0;
            int pointsld = 0;

            int heartf = 0;
            int pointsHeartf = 0;

            int cd = 0;
            int pointscd = 0;

            int rd = 0;
            int pointsrd = 0;

            int ams = 0;
            int pointsams = 0;

            int peXray = 0;
            int pointsPeXray = 0;

            String rr = txtRR.Text;
            double respitoryR = Convert.ToDouble(rr);
            int pointsrr = 0;

            String boxsbp = txtSBP.Text;
            double sbp = Convert.ToDouble(boxsbp);
            int pointssbp = 0;

            String boxTemp = txtTemp.Text;
            double temp = Convert.ToDouble(boxTemp);
            int pointstemp = 0;

            String boxPulse = txtPulse.Text;
            double pulse = Convert.ToDouble(boxPulse);
            int pointspulse = 0;

            String boxPh = txtPh.Text;
            double pH = Convert.ToDouble(boxPh);
            int pointsph = 0;

            String boxBun = txtBUN.Text;
            double bun = Convert.ToDouble(boxBun);
            int pointsbun = 0;

            String boxSodium = txtSodium.Text;
            double sodium = Convert.ToDouble(boxSodium);
            int pointsSodium = 0;

            String boxGlucose = txtGlucose.Text;
            double glucose = Convert.ToDouble(boxGlucose);
            int pointsGlucose = 0;

            String boxHemotocrit = txtHemotocrit.Text;
            double hemotocrit = Convert.ToDouble(boxHemotocrit);
            int pointsHemotocrit = 0;

            String boxppo = txtPPO.Text;
            double ppo = Convert.ToDouble(boxppo);
            int pointsPpo = 0;

            double mgdlbun;
            double glucosemgdl;
            double ppomgdl;
            double tempCel;



            if (Convert.ToBoolean(rdoMale.IsChecked))
            {
                sex = "male";
                pointsSex = 0;

            }
            else if (Convert.ToBoolean(rdoFemale.IsChecked))
            {
                sex = "female";
                pointsSex = -10;

            }
            else if (Convert.ToBoolean(rdoMale.IsChecked) && Convert.ToBoolean(rdoFemale.IsChecked))
            {
                MessageBox.Show("Please choose only one value for sex.");

            }//end if

            if (Convert.ToBoolean(chkYesNH.IsChecked))
            {
                nursinghomeRes = 1;
                pointsNursingHomeRes = 10;

            }
            else if (Convert.ToBoolean(chkNoNH.IsChecked))
            {
                nursinghomeRes = 0;
                pointsNursingHomeRes = 0;

            }
            else if (Convert.ToBoolean(chkYesNH.IsChecked) && Convert.ToBoolean(chkNoNH.IsChecked))
            {
                MessageBox.Show("Please choose only one value for nursing home.");
            }//end if

            if (Convert.ToBoolean(chkYesND.IsChecked))
            {
                nd = 1;
                pointsnd = 30;
            }
            else if (Convert.ToBoolean(chkNoND.IsChecked))
            {
                nd = 0;
                pointsnd = 0;

            } else if (Convert.ToBoolean(chkNoND.IsChecked) && Convert.ToBoolean(chkYesND.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Neoplastic Disease.");
            }//end if

            if (Convert.ToBoolean(chkYesLD.IsChecked))
            {
                ld = 1;
                pointsld = 20;

            } else if (Convert.ToBoolean(chkNoLD.IsChecked))
            {
                ld = 0;
                pointsld = 0;

            } else if (Convert.ToBoolean(chkYesLD.IsChecked) && Convert.ToBoolean(chkNoLD.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Liver Disease.");

            }//end if

            if (Convert.ToBoolean(chkYesCHF.IsChecked))
            {
                heartf = 1;
                pointsHeartf = 10;

            }
            else if (Convert.ToBoolean(chkNoCHF.IsChecked))
            {
                heartf = 0;
                pointsHeartf = 0;

            } else if (Convert.ToBoolean(chkYesCHF.IsChecked) && Convert.ToBoolean(chkNoCHF.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Congestive Heart Failure.");

            }//end if

            if (Convert.ToBoolean(chkYesCD.IsChecked))
            {
                cd = 1;
                pointscd = 10;

            }
            else if (Convert.ToBoolean(chkNoCD.IsChecked))
            {
                cd = 0;
                pointscd = 0;

            }
            else if (Convert.ToBoolean(chkYesCD.IsChecked) && Convert.ToBoolean(chkNoCD.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Cerebrovascular Disease.");

            }//end if

            if (Convert.ToBoolean(chkYesRD.IsChecked))
            {
                rd = 1;
                pointsrd = 10;

            }
            else if (Convert.ToBoolean(chkNoRD.IsChecked))
            {
                rd = 0;
                pointsrd = 0;

            }
            else if (Convert.ToBoolean(chkYesRD.IsChecked) && Convert.ToBoolean(chkNoRD.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Renal Disease.");

            }//end if

            if (Convert.ToBoolean(chkYesAMS.IsChecked)) {
                ams = 1;
                pointsams = 20;

            }
            else if (Convert.ToBoolean(chkNoAMS.IsChecked))
            {
                ams = 0;
                pointsams = 0;

            }
            else if (Convert.ToBoolean(chkYesAMS.IsChecked) && Convert.ToBoolean(chkNoAMS.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Altered Mental Status.");

            }//end if

            if (respitoryR > 30)
            {
                pointsrr = 20;
            }
            else
            {
                pointsrr = 0;
            }//end if

            if (sbp < 90)
            {
                pointssbp = 20;
            }
            else
            {
                pointssbp = 0;
            }//end if

            if (Convert.ToBoolean(rdoTempCel.IsChecked))
            {
                if (temp < 35 || temp > 39.9)
                {
                    pointstemp = 15;
                }
                else
                {
                    pointstemp = 0;
                }//end if
            }
            else if (Convert.ToBoolean(rdoTempFar.IsChecked))
            {
                if (temp < 95 || temp > 103.8)
                {
                    pointstemp = 15;
                }
                else
                {
                    pointstemp = 0;
                }//end if

            }
            else if ((Convert.ToBoolean(rdoTempCel.IsChecked) && Convert.ToBoolean(rdoTempFar.IsChecked))) {

                MessageBox.Show("Please choose only one temperature unit.");

            }//end if

            if (pulse > 125)
            {
                pointspulse = 10;

            }
            else
            {
                pointspulse = 0;

            }//end if

            if (pH < 7.35)
            {
                pointsph = 30;

            }
            else
            {
                pointsph = 0;

            }//end if

            if (Convert.ToBoolean(rdomgdlGlucose.IsChecked))
            {
                if (bun >= 30)
                {
                    pointsbun = 20;
                }
                else
                {
                    pointsbun = 0;
                }//end if

            }
            else if (Convert.ToBoolean(rdommolBUN.IsChecked))
            {
                if (bun >= 11)
                {
                    pointsbun = 20;
                }
                else
                {
                    pointsbun = 0;
                }//end if

            }
            else
            {
                MessageBox.Show("Please choose only one BUN unit.");
            }//end else

            if (sodium < 130)
            {
                pointsSodium = 20;
            }
            else
            {
                pointsSodium = 0;
            }//end if

            if (Convert.ToBoolean(rdomgdlBUN.IsChecked))
            {
                if (glucose >= 250)
                {
                    pointsGlucose = 10;
                }
                else
                {
                    pointsGlucose = 0;
                }//end if

            }
            else if (Convert.ToBoolean(rdommolGlucose.IsChecked))
            {
                if (glucose >= 14)
                {
                    pointsGlucose = 10;
                }
                else
                {
                    pointsGlucose = 0;
                }//end if

            }
            else
            {
                MessageBox.Show("Please choose only one glucose unit.");
            }//end if

            if (hemotocrit < 30)
            {
                pointsHemotocrit = 10;
            }
            else
            {
                pointsHemotocrit = 0;
            }//end if

            if (Convert.ToBoolean(rdommhgPPO.IsChecked))
            {
                if (ppo < 60)
                {
                    pointsPpo = 10;
                }
                else
                {
                    pointsPpo = 0;
                }//end if

            }
            else if (Convert.ToBoolean(rdokPa.IsChecked))
            {
                if (ppo < 8)
                {
                    pointsPpo = 10;
                }
                else
                {
                    pointsPpo = 0;
                }//end if

            }
            else
            {
                MessageBox.Show("Please choose only one Partial Pressure of Oxygen unit.");
            }//end if

            if (Convert.ToBoolean(chkPEXYes.IsChecked))
            {
                peXray = 1;
                pointsPeXray = 10;

            }
            else if (Convert.ToBoolean(chkNoCHF.IsChecked))
            {
                peXray = 0;
                pointsPeXray = 0;

            }
            else if (Convert.ToBoolean(chkYesCHF.IsChecked) && Convert.ToBoolean(chkNoCHF.IsChecked))
            {
                MessageBox.Show("Please choose only one value for Pleural Effusion on x-ray.");

            }//end if

            points = ageNum + pointsSex + pointsNursingHomeRes + pointsnd + pointsld + pointsHeartf + pointscd + pointsrd + pointsams + pointsrr + pointssbp + pointstemp + pointspulse + pointsph + pointsbun + pointsSodium + pointsGlucose + pointsHemotocrit + pointsPpo + pointsPeXray;

            if (cd == 0 && nd == 0 && ld == 0 && heartf == 0 && rd == 0 && ams == 0 && peXray == 0 && pointsph == 0 && pointsbun == 0 && pointsSodium == 0 && pointsGlucose == 0 && pointsHemotocrit == 0 && pointsPpo == 0)
            {
                txtRecommendation.Text = "Risk Class 1 : Low Risk : Recommendation - Outpaitent Care";
            }
            else if (points <= 70)
            {
                txtRecommendation.Text = "Risk Class 2 : Low Risk : Recommendation - Outpatient Care";
            }
            else if (points >= 71 && points <= 90)
            {
                txtRecommendation.Text = "Risk Class 3 : Low Risk : Recommendation - Outpatient Care or Observation Admission";

            }
            else if (points >= 91 && points <= 130)
            {
                txtRecommendation.Text = "Risk Class 4 : Moderate Risk : Recommendation - Inpatient Admission";
            }
            else if (points > 130)
            {
                txtRecommendation.Text = "Risk Class 5 : High Risk : Recommendation - Inpatient Admission & Sepsis Check";
            }//end if

            if (Convert.ToBoolean(rdoTempFar.IsChecked))
            {
                tempCel = (temp - 32) * 5 / 9;
            }
            else
            {
                tempCel = temp;
            }//end if

            if (Convert.ToBoolean(rdommolBUN.IsChecked))
            { 
                mgdlbun = bun * 18;
            }
            else
            {

                mgdlbun = bun;
            }//end if

            if (Convert.ToBoolean(rdommolGlucose.IsChecked))
            {
                glucosemgdl = glucose * 18;
            }
            else
            {
                glucosemgdl = glucose;
            }//end if

            if (Convert.ToBoolean(rdokPa.IsChecked))
            {
                ppomgdl = ppo * 7.501;

            }
            else
            {
                ppomgdl = ppo;
            }

            patientID++;

            try
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\cporter\source\repos\PSI_CNP\data.csv"))
                {
                    sw.WriteLine($"Patient ID: {patientID}, Age: {age}, Sex: {sex}, Nursing Home Resident: {nursinghomeRes}, Neoplastic Disease: {nd}, Liver Disease: {ld}, Congestive Heart Failure: {heartf}, Cerebrovascular Disease: {cd}" +
                        $"Renal Disease: {rd}, Altered Mental Status: {ams}, Respitory Rate: {respitoryR}, Systolic Blood Pressure: {sbp}mmHG, Temperature: {tempCel} celcius, Pulse: {pulse}, pH: {pH}" +
                        $"BUN: {mgdlbun}mg/dL, Sodium: {sodium}mmol/L, Glucose: {glucose}mg/dL, Hemotocrit: {hemotocrit}%, Partial Pressure of Oxygen: {ppomgdl}mmHg, Pleural Effusion on x-ray: {peXray}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }//end catch
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex);
            }
             

        }//end click
    }
}
