using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SERIAL_COMMINICATION_BASE_FORM
{
    public static class Static
    {
        //C# 9.0
        //public static StepMod ButtonToStepModee(Button button) =>
        //            switch (button.Name)
        //    {
        //        "BtnStandartMod" => StepMod.STANDART_MOD,
        //        "BtnTetiklemeliMod" => StepMod.TETIKLEMELI_MOD,
        //        "BtnManuelMod" => StepMod.MANUEL_MOD,
        //        "BtnSinirliAciMod" => StepMod.ACI_SINIRLI_MOD,
        //        "BtnTetiklemeliSinirliAciMod" => StepMod.TETIKLEMELI_ACI_SINIRLI_MOD,
        //        "BtnTekYonTetiklemeliSinirliAciMod" => StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD,
        //        "BtnKalibrasyonMod" => StepMod.KALIBRASYON_MODU
        //    };


        public static void SetVisibleControl(bool visible, params Control[] control)
        {
            foreach (Control c in control)
            {
                c.Visible = visible;
            }
        }

        public static void SetBackColorControl(Color color, params Control[] control)
        {
            foreach (Control c in control)
            {
                c.BackColor = color;
            }
        }

        public static Parity StringToParity(string parity)
        {
            switch (parity)
            {
                case "None":
                    return Parity.None;
                case "Even":
                    return Parity.Even;
                case "Odd":
                    return Parity.Odd;
                case "Mark":
                    return Parity.Mark;
                case "Space":
                    return Parity.Space;
                default:
                    return Parity.None;
            }
        }
    }
}
