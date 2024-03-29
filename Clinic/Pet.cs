﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;

namespace VetClinicPatientMgtProject.Clinic
{
    public class Pet
    {
        public string name { get; set; }
        public DateTime dateTime { get; set; }

        DoublyLinkedList<Sickness> sickness = null;

        public Pet(string name, DateTime dateTime)
        {
            this.name = name;
            sickness = new DoublyLinkedList<Sickness>();
            this.dateTime = dateTime;
        }

        public void AddSickness(Sickness s)
        {

            sickness.PushBack(s);
        }
        public int CalculateScore()
        {
            int score = 0;

            var current = sickness.GetHead();

            while (current != null)
            {
                score += current.data.severity * current.data.time + current.data.contagious;
                current = current.next;
            }
            return score;

        }
        public DoublyLinkedList<Sickness> GetSickness()
        {
            return sickness;
        }

      
    }
}
