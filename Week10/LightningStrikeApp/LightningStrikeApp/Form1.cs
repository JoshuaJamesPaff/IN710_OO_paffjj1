using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningStrikeApp
{
    public partial class Form1 : Form
    {
        private LightningStrikesDbDataContext db = new LightningStrikesDbDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        //average strike intesity across the tblStrikes table
        private void buttonAvgIntensity_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();

            var avg = (from strike in db.tblStrikes
                       select strike.strikeIntensity).Average();

            listBoxDisplay.Items.Add("Average Strike intensity: " + avg);
            
        }

        //top 3 fires by area in descending order
        private void buttonThreeFires_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();

            int numberOfRecords = 3;

            var fires = (from fire in db.tblFires
                              orderby fire.fireArea descending
                              select fire).Take(numberOfRecords);

            foreach (var fire in fires)
            {
                listBoxDisplay.Items.Add("FireID: " + fire.fireID + "    " + "\tDate: " + fire.fireDate + "\tLat: " + fire.fireLatitude + "\tLong: " + fire.fireLongitude + "\tArea: " + fire.fireArea);
            }       
        }

        //displays latitude and longitude for each picture
        private void buttonLatLong_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();

            // joins pictures table with strikes table (only takes Lat + Long)
            var picturesAndStrikes = from picture in db.tblPictures
                                       join strike in db.tblStrikes
                                       on picture.strikeID equals strike.strikeID
                                       select new { picture, strike.strikeLatitude, strike.strikeLongitude};

            //prints each picture
            foreach (var picture in picturesAndStrikes)
            {
                listBoxDisplay.Items.Add("PictureID: " + picture.picture.pictureID + "\tLat: " + picture.strikeLatitude + "\tLong: " + picture.strikeLongitude);
            }

        }

        private void buttonFiresByLightning_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();

            // joins pictures table with strikes table (only takes Lat + Long)
            var firesCausedByLightning = from fire in db.tblFires
                                     join strike in db.tblStrikes
                                     on new { date = fire.fireDate, latitude = fire.fireLatitude, longitude = fire.fireLongitude } equals new { date = strike.strikeDate, latitude = strike.strikeLatitude, longitude = strike.strikeLongitude }
                                     select fire;

            //prints each picture
            foreach (var fire in firesCausedByLightning)
            {
                listBoxDisplay.Items.Add("FireID: " + fire.fireID + " " + " \tDate: " + fire.fireDate + "\tLat: " + fire.fireLatitude + "\tLong: " + fire.fireLongitude + "\tArea: " + fire.fireArea);
            }
        }
    }
}
