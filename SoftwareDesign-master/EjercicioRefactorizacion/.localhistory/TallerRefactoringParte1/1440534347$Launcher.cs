using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TallerRefactoringParte1 {
    public static class Launcher {
    [STAThread]
        public static void main(string[] args){
            Application.Run(new FormularioSolicitud());
            Application.Exit();
        }
    }
}
