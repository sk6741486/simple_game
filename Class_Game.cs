﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
   public class Class_Game
    {
        public int load_position;
        public int spin_position;
        public int shoot_position;
        public int chance=0;

        public void load()
        {
            load_position = 1;
        }

        public int spin()
        {
            Random rnd_obj=new Random();
            spin_position = rnd_obj.Next(1, 7);
            return spin_position;
        }

        public int shoot()
        {
            if (load_position == spin_position)
            {
                return 0;
            }
            else if (spin_position == 6)
            {
                spin_position = 1;
                return 1;
            }
            else
            {
                spin_position++;
                return 1;
             }
            }
        }          
    }

