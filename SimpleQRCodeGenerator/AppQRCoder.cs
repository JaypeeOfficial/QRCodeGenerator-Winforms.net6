using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQRCodeGenerator
{
    public class AppQRCoder
    {
        public static Bitmap GetCode (string code, bool withLogo = false) {

            using QRCodeGenerator generator = new QRCodeGenerator();
            using QRCodeData data = generator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            using QRCode qRCode = new QRCode(data);

            return qRCode.GetGraphic(
                          20,
                          Color.Black,
                          Color.White,
                          withLogo ? new Bitmap(Properties.Resources.RDF) : null
                );


        }




    }
}
