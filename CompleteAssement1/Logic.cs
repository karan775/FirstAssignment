using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public class LogicClass
  {
   int Gunbullet = 0;
   int Chance = 2;
  public void ShootingButtornFaraway()
{
  if (Chance > 0)
{
  if (Gunbullet == 5)
{           
  MessageBox.Show("You survived . \nYour Score : " + Gunbullet+ (Gunbullet ==5 ?"\n \n You Gain" : "\n You failure"));
}
  else
  {
  MessageBox.Show("Gun Rotated Successfully");
 Gunbullet = Gunbullet + 1;
}               
}          
else
{
MessageBox.Show(" ooh! You'r Dead");
}
Chance = Chance - 1;
}
public void TryitagainButton()
  {
 Gunbullet = 0;
 Chance = 2;
 MessageBox.Show("Your Game is Start");
 }
        public void SwitchGunButton()   
{
Random rand = new Random();
Gunbullet = rand.Next(0, 6);
MessageBox.Show("Your Gun Switch");
}                          
        public void GunReloadButton()   
{
  Gunbullet = 0;
   MessageBox.Show("Your Gun is Reload Successfully");
}
public void GunFiringButton()
{
if (Gunbullet == 5)
{
MessageBox.Show(" ooh! You'r Dead");
}
else
{
MessageBox.Show("Your Gun is Shooting");
Gunbullet = Gunbullet + 1; }
}   }  }
