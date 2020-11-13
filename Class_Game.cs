using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
   public class Class_Game
    {
        public int load_position;//for data
        public int spin_position;//for data
        public int shoot_position;//for data
        public int chance=0;//
        
        public void load()
        {
            load_position = 1;
        }
        // code load gun when click on load button
        public int spin()
        {
            Random rnd_obj=new Random();//for random chance
            spin_position = rnd_obj.Next(1, 7);//for take chances
            return spin_position;
        }
        //spin the chamber of gun when click on spin button
        public int shoot()//shoot code for shoot on head
        {
            if (load_position == spin_position)
            {
                return 0;
            }
            else if (spin_position == 6)//code for last chance of shoot
            {
                spin_position = 1;
                return 1;
            }
            else
            {
                spin_position++;
                return 1;//
             }
            }
        }          
    }

