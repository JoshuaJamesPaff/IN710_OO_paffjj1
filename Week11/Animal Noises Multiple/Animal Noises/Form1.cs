﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Animal> animalList;
        private List<Thread> threadList;
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //token shared by animals
            SharedToken sharedToken = new SharedToken();

            animalList = new List<Animal>();
            threadList = new List<Thread>();

            animalList.Add(new Animal("frog.wav", sharedToken));
            animalList.Add(new Animal("duck.wav", sharedToken));
            animalList.Add(new Animal("meow.wav", sharedToken));

            for (int i = 0; i < animalList.Count; i++)
                threadList.Add(new Thread(animalList[i].speak)); 
            
            for (int i = 0; i < animalList.Count; i++){
                threadList[i].Start();
                
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Abort();
        }


    }
}
