using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MiniGame.Class
{
    internal class User
    {
        
        Random rnd = new Random();
        public string Name { get; set; }
        public int[] GunBullets = new int[] {0,0,0,0,0,0};
        public bool live { get; set; }
        private int indexCurrent { get; set; }
        public void LoadGun()
        {
            int indexBullet = rnd.Next(0,6);
            GunBullets[indexBullet] = 1;
            indexCurrent = 0;
            live = true;
        }
        
        public void Shoot()
        {
            SoundPlayer breath = new SoundPlayer();
            breath.Stream = Properties.Resources.deep_breath_247459;
            
            SoundPlayer click = new SoundPlayer();
            click.Stream = Properties.Resources.gun_cocking_sound_270163;
            SoundPlayer shoot = new SoundPlayer();
            shoot.Stream = Properties.Resources.single_gunshot_62_hp_37188__1_;

            SoundPlayer kill = new SoundPlayer();
            kill.Stream = Properties.Resources.nguoichoibiloai;

            if (live == true) {


                if (GunBullets[indexCurrent] == 1)
                {
                    breath.Play();
                    Thread.Sleep(3000);
                    click.Play();
                    shoot.Play();
                    live = false;
                    Thread.Sleep(3000);
                    kill.Play();
                }
                else
                {
                    breath.Play();
                    Thread.Sleep(3000);
                    click.Play();
                    live= true;
                    indexCurrent++;
                }
            }
            else
            {
                MessageBox.Show("Người chơi đã bị hạ , không thể bắn");
            }
        }
       
    }
}
