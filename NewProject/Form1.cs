using System;
using System.Runtime.ExceptionServices;

namespace NewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BtAjouter_Click(object sender, EventArgs e)
        {

            try
            {
                //Validation of Prix , Qte
                double input;
                bool validInputPrix = double.TryParse(TbPrix.Text, out input);
                bool validInputQte = double.TryParse(TbQte.Text, out input);

                if (!validInputPrix)
                {
                    MessageBox.Show("Veuillez entrer le Prix valide");
                    TbPrix.Text = "";
                }

                if (!validInputQte)
                {
                    MessageBox.Show("Veuillez entrer la quantite valide");
                    TbQte.Text = "";
                }
                

                //Print the information
                string des = TbDes.Text;
                double prix = double.Parse(TbPrix.Text);
                int qte = int.Parse(TbQte.Text);



                double MHT = prix * qte;
                double MTVA;
                double Taux = 0;

                //Create a list for includ the information
                ListViewItem article = new ListViewItem();

                //The first we do text and for the sd we create SubItems 
                article.Text = TbDes.Text;
                //Show the "Prix" in the table in the second Place [1]
                article.SubItems.Add(prix.ToString("N2"));
                article.SubItems.Add(TbQte.Text);
                article.SubItems.Add(MHT.ToString("N2"));

                //Condition for choose the TVA
                if (Rb7.Checked) Taux = 0.07d;
                else if (Rb20.Checked) Taux = 0.2d;
                else
                {
                    MessageBox.Show("Veuillez selectionner la TVA.");
                    Rb7.ForeColor = Rb20.ForeColor = Color.Red;
                }

                MTVA = Taux * MHT;
                article.SubItems.Add(MTVA.ToString("N2"));
                article.SubItems.Add((MTVA + MHT).ToString("N2"));

                //Condition for don't show the info when radiobutton both false
                if ((Rb7.Checked == true || Rb20.Checked == true) && des.Trim().ToString() != "")
                {
                    Lv.Items.Add(article);
                    Effacer();
                }

                if(des.Trim().ToString() == "")
                    MessageBox.Show("Remplissez la Desiniation vide");

                //Fonction for calculate
                CalculerToteaux();

            }
            catch
            {
                //When the info is not correct or is null and Show A Message
                /*if (TbPrix.Text == "" || TbQte.Text == "" || TbDes.Text == "")
                {
                    MessageBox.Show("Remplissez l'espace vide ou vérifier les information");
                }*/

            }


        }

        private void BtEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }



        private void BtQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSupprimer_Click(object sender, EventArgs e)
        {
            if (Lv.SelectedIndices.Count == 1)
            {
                int selectedIndice = Lv.SelectedIndices[0];
                Lv.Items[selectedIndice].Remove();
                CalculerToteaux();
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne");
            }
        }

        int IndiceModifier = -1;
        private void BtModifier_Click(object sender, EventArgs e)
        {
            if (IndiceModifier == -1)
            {
                if (Lv.SelectedIndices.Count == 1)
                {

                    int SelectedIndices = Lv.SelectedIndices[0];
                    IndiceModifier = Lv.SelectedIndices[0];
                    TbDes.Text = Lv.Items[IndiceModifier].SubItems[0].Text;
                    TbPrix.Text = Lv.Items[IndiceModifier].SubItems[1].Text;
                    TbQte.Text = Lv.Items[IndiceModifier].SubItems[2].Text;

                    double MHT = double.Parse(Lv.Items[IndiceModifier].SubItems[3].Text);
                    double MTVA = double.Parse(Lv.Items[IndiceModifier].SubItems[4].Text);

                    double taux = (MTVA / MHT);

                    if (taux < 0.1) Rb7.Checked = true;
                    else Rb20.Checked = true;

                    BtAjouter.Enabled = false;
                    BtEffacer.Enabled = false;
                    BtSupprimer.Enabled = false;
                    BtQuitter.Enabled = false;
                    BtModifier.Text = "Valider";

                }
                else
                {
                    MessageBox.Show("Selectionnez une ligne");
                }
            }
            else
            {
                try
                {
                    Lv.Items[IndiceModifier].SubItems[0].Text = TbDes.Text;
                    Lv.Items[IndiceModifier].SubItems[1].Text = TbPrix.Text;
                    Lv.Items[IndiceModifier].SubItems[2].Text = TbQte.Text;

                    //Validation of Prix , Qte
                    double input;
                    bool validInputPrix = double.TryParse(TbPrix.Text, out input);
                    bool validInputQte = double.TryParse(TbQte.Text, out input);

                    if (!validInputPrix)
                    {
                        MessageBox.Show("Veuillez entrer le Prix valide");
                        TbPrix.Text = "";
                    }

                    if (!validInputQte)
                    {
                        MessageBox.Show("Veuillez entrer la quantite valide");
                        TbQte.Text = "";
                    }

                    

                    double prix = double.Parse(TbPrix.Text);
                    int qte = int.Parse(TbQte.Text);
                    double MHT = prix * qte;
                    double PTVA;
                    double tva = 0;
                    if (TbDes.Text.Trim() == "")
                        MessageBox.Show("Remplissez la Desiniation vide");

                    if ((Rb7.Checked == true || Rb20.Checked == true) && TbDes.Text.Trim() != "")
                    {

                        if (Rb7.Checked) tva = 0.07d;
                        else if (Rb20.Checked) tva = 0.2d;

                        PTVA = tva * prix;

                        Lv.Items[IndiceModifier].SubItems[3].Text = MHT.ToString("N2");
                        Lv.Items[IndiceModifier].SubItems[4].Text = PTVA.ToString("N2");
                        Lv.Items[IndiceModifier].SubItems[5].Text = (MHT + PTVA).ToString("N2");



                        BtAjouter.Enabled = true;
                        BtEffacer.Enabled = true;
                        BtSupprimer.Enabled = true;
                        BtQuitter.Enabled = true;
                        BtModifier.Text = "Modifier";
                        CalculerToteaux();
                        Effacer();
                        
                        IndiceModifier = -1;
                    }
                    

                }
                catch
                {
                    

                }

            }





        }


        private void Effacer()
        {
            TbDes.Text = "";
            TbPrix.Text = "";
            TbQte.Text = "";
            Rb7.Checked = Rb20.Checked = false;
            Rb7.ForeColor = Rb20.ForeColor = Color.Black;

        }
        private void CalculerToteaux()
        {
            double THT = 0;
            double TTVA = 0; double TNET;
            for (int i = 0; i < Lv.Items.Count; i++)
            {
                THT += double.Parse(Lv.Items[i].SubItems[3].Text);
                TTVA += double.Parse(Lv.Items[i].SubItems[4].Text);
            }

            TNET = THT + TTVA;


            TbTHT.Text = THT.ToString("N2");
            TbTTVA.Text = TTVA.ToString("N2");
            TbNET.Text = TNET.ToString("N2");
        }
    }
}