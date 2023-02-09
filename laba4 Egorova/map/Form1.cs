using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

       

        private void start2_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "2 старт\n5 км до Реки";
            LandmarkName.Text = "5 км до Реки";
            ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }


        private void start1_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Начало старта\nЧасовой чонго марофон";
            ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void point1_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "МЦК Лужники";
            ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point2_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Новодевичей монастырь";
          ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void point3_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Метро Киевская";
            ServicesProvided.Visible = false;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point4_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "МИД";
           ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 292); MedicalText.Location = new Point(62, 307);
 
        }

        private void point5_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Парк Горького";
            ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
 
        }

        private void point6_Click(object sender, EventArgs e)
        {
           
            LandmarkName.Text = "Здания РАН";
            ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point7_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Метро Воробевы горы";
            ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void start3_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Веселый старт\n5 км веселого бега";
           ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point8_Click(object sender, EventArgs e)
        {
            
            LandmarkName.Text = "Стадион Лужники";
            ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            LandmarkName.Text = "Финиш\nУра! Забег окончен.\n Поздравняем!";
            ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

      
    }
}