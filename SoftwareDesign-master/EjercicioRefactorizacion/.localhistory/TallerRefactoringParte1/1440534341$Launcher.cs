using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TallerRefactoringParte1 {
    [STAThread]
    public static class Launcher {
        public static void main(string[] args){
            Application.Run(new FormularioSolicitud());
            Application.Exit();
        }
    }
}
