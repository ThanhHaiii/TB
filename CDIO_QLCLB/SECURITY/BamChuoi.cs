using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.SECURITY
{
    class BamChuoi
    {
        public string maHoaKyTu(string chuoikyTu)
        {
            string chuoiRa = "";
            for (int i = 0; i < chuoikyTu.Length; i++)
            {
                string tach = chuoikyTu.Substring(i, 1);
                chuoiRa += maHoa(tach);
            }
            return chuoiRa;
        }

        private string maHoa(string kyTu)
        {
            string kQ = "";
            switch (kyTu)
            {
                case "!":
                    kQ = "@Ba22C";
                    return kQ;
                case "@":
                    kQ = "%bNB#";
                    return kQ;
                case "#":
                    kQ = "C(D+4";
                    return kQ;
                case "$":
                    kQ = "*Hj2A";
                    return kQ;
                case "%":
                    kQ = "$Mj34";
                    return kQ;
                case "^":
                    kQ = "k%2V.";
                    return kQ;
                case "&":
                    kQ = "Lit+9+5";
                    return kQ;
                case "*":
                    kQ = ".N6$j";
                    return kQ;
                case "(":
                    kQ = "Me@3q;";
                    return kQ;
                case ")":
                    kQ = "jJh!8";
                    return kQ;
                case "-":
                    kQ = "*%jHj";
                    return kQ;
                case "_":
                    kQ = "nI#g>";
                    return kQ;
                case "+":
                    kQ = "*%Kl5";
                    return kQ;
                case "=":
                    kQ = "nHt%9+:";
                    return kQ;
                case "0":
                    kQ = "!h@jB";
                    return kQ;
                case "1":
                    kQ = "X3425/$a";
                    return kQ;
                case "2":
                    kQ = "^hG8a";
                    return kQ;
                case "3":
                    kQ = "W#odk";
                    return kQ;
                case "4":
                    kQ = "iJ&m0";
                    return kQ;
                case "5":
                    kQ = "h^&*j";
                    return kQ;
                case "6":
                    kQ = "fG+89t&9";
                    return kQ;
                case "7":
                    kQ = "85645&j";
                    return kQ;
                case "8":
                    kQ = "16Yh)";
                    return kQ;
                case "9":
                    kQ = "#$%hG";
                    return kQ;
                case "q":
                    kQ = "ZzX%x";
                    return kQ;
                case "Q":
                    kQ = "XxZZ!";
                    return kQ;
                case "w":
                    kQ = "bCd&@";
                    return kQ;
                case "W":
                    kQ = "@ZZ25";
                    return kQ;
                case "e":
                    kQ = "DeG%7";
                    return kQ;
                case "E":
                    kQ = "*H24jh*";
                    return kQ;
                case "r":
                    kQ = "E6$$8";
                    return kQ;
                case "R":
                    kQ = "SsL)(";
                    return kQ;
                case "t":
                    kQ = "rEF897&";
                    return kQ;
                case "T":
                    kQ = "jH&&k";
                    return kQ;
                case "y":
                    kQ = "jU%=C";
                    return kQ;
                case "Y":
                    kQ = "Wi7o(0";
                    return kQ;
                case "u":
                    kQ = "Li*ku";
                    return kQ;
                case "U":
                    kQ = "@h^6@";
                    return kQ;
                case "i":
                    kQ = "@ki89#";
                    return kQ;
                case "I":
                    kQ = "$5Hv%";
                    return kQ;
                case "o":
                    kQ = "B@#kl";
                    return kQ;
                case "O":
                    kQ = "(@15)";
                    return kQ;
                case "p":
                    kQ = "mF64&k9";
                    return kQ;
                case "P":
                    kQ = "6K3g#";
                    return kQ;
                case "{":
                    kQ = "CCjH*";
                    return kQ;
                case "}":
                    kQ = "Q%2C";
                    return kQ;
                case "[":
                    kQ = "%a3QC";
                    return kQ;
                case "|":
                    kQ = "CB#89C";
                    return kQ;
                case "a":
                    kQ = "C2@d^";
                    return kQ;
                case "A":
                    kQ = "B*/*Q4a";
                    return kQ;
                case "s":
                    kQ = "@#$%j";
                    return kQ;
                case "S":
                    kQ = "kI8j&";
                    return kQ;
                case "d":
                    kQ = "bC/3!";
                    return kQ;
                case "D":
                    kQ = "###D2";
                    return kQ;
                case "f":
                    kQ = "!!#Fx";
                    return kQ;
                case "F":
                    kQ = "@Bb#82";
                    return kQ;
                case "g":
                    kQ = "#$a2C";
                    return kQ;
                case "G":
                    kQ = "@#B9C";
                    return kQ;
                case "h":
                    kQ = "*JG9+#t";
                    return kQ;
                case "H":
                    kQ = "BKaV$";
                    return kQ;
                case "j":
                    kQ = "YbUF%";
                    return kQ;
                case "J":
                    kQ = "*kH#t";
                    return kQ;
                case "k":
                    kQ = "*sD&t";
                    return kQ;
                case "K":
                    kQ = "&!*H98+a";
                    return kQ;
                case "l":
                    kQ = "%Je*t";
                    return kQ;
                case "L":
                    kQ = "*Jw$5";
                    return kQ;
                case ";":
                    kQ = "SQL$9";
                    return kQ;
                case ":":
                    kQ = "$QL25";
                    return kQ;
                case "'":
                    kQ = "$QL#0";
                    return kQ;
                case "z":
                    kQ = "3652A";
                    return kQ;
                case "Z":
                    kQ = "*389652";
                    return kQ;
                case "x":
                    kQ = "45#c3";
                    return kQ;
                case "X":
                    kQ = "/05Ah";
                    return kQ;
                case "c":
                    kQ = "BTVn%";
                    return kQ;
                case "C":
                    kQ = "BtV2%";
                    return kQ;
                case "v":
                    kQ = "4%25+89f";
                    return kQ;
                case "V":
                    kQ = "%4589+F2";
                    return kQ;
                case "b":
                    kQ = "089+147#";
                    return kQ;
                case "B":
                    kQ = "%16b%";
                    return kQ;
                case "n":
                    kQ = "5&2Gg";
                    return kQ;
                case "N":
                    kQ = "bKm%t";
                    return kQ;
                case "m":
                    kQ = "&^%13";
                    return kQ;
                case "M":
                    kQ = "%^&189a";
                    return kQ;
                case ",":
                    kQ = "#*#*b";
                    return kQ;
                case "<":
                    kQ = "12$uS";
                    return kQ;
                case ">":
                    kQ = "15#4h";
                    return kQ;
                case "/":
                    kQ = "15@2%";
                    return kQ;
                case "?":
                    kQ = "4&%89+Fh";
                    return kQ;
            }
            return kyTu;
        }
    }
}
