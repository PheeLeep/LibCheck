using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace LibCheck.Modules {

    internal static class QRCamModule {

        internal static Bitmap GenerateQR(string data) {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions() {
                Width = 300,
                Height = 300,
                CharacterSet = "UTF-8"
            };
            BarcodeWriter writer = new BarcodeWriter() {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };
            return writer.Write(data);
        }
    }
}
