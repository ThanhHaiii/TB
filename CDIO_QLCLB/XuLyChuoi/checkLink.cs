using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.XuLyChuoi
{
    class checkLink
    {
        private int startIndex;
        private int endIndex;
        private string content;

        public checkLink()
        {

        }
        public checkLink(string content, int startIndex, int endIndex)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
            this.content = content;
        }

        public int getStartIndex()
        {
            return startIndex;
        }

        public void setStartIndex(int startIndex)
        {
            this.startIndex = startIndex;
        }

        public int getEndIndex()
        {
            return endIndex;
        }

        public void setEndIndex(int endIndex)
        {
            this.endIndex = endIndex;
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public List<checkLink> DetectLink(string input)
        {
            input = input.Replace("\r\n", " ");

            List<checkLink> result = new List<checkLink>();

            int tempStartIndex = 0;
            int tempEndIndex = 0;
            checkLink linkInfo;

            int lengthInput = input.Length;

            do
            {
                while (tempStartIndex < lengthInput && (char)input[tempStartIndex] == ' ')
                {
                    tempStartIndex++;
                }

                tempEndIndex = input.IndexOf(" ", tempStartIndex);

                if (tempEndIndex != -1)
                {
                    string content = input.Substring(tempStartIndex, tempEndIndex - tempStartIndex);

                    if (check(content))
                    {
                        linkInfo = new checkLink(content, tempStartIndex, tempEndIndex);
                        result.Add(linkInfo);
                    }

                }
                else
                {

                    tempEndIndex = lengthInput;

                    string content = input.Substring(tempStartIndex, tempEndIndex - tempStartIndex);

                    if (check(content))
                    {
                        linkInfo = new checkLink(content, tempStartIndex, tempEndIndex - tempStartIndex);
                        result.Add(linkInfo);
                    }
                }

                tempStartIndex = tempEndIndex;
            } while (tempStartIndex < lengthInput);

            return result;
        }

        private static bool check(string input)
        {
            int tempDotIndex = input.IndexOf(".");

            if (tempDotIndex != -1 && tempDotIndex != 0 && tempDotIndex != input.Length - 1)
            {
                if (check2(input))
                    return true;
                else
                    return false;
            }

            return false;
        }

        private static bool check2(string input)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(input);
                WebResponse webResponse;
                webResponse = webRequest.GetResponse();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}