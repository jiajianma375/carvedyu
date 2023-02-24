using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CYCommon
{
    public class CHkToken
    {
        public string SubscriptionId { get; set; }
        public string ActivityName { get; set; }
        public string Nonce { get; set; }

        public string Encode()
        {
            var json = JsonConvert.SerializeObject(this);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
        }

        public static CHkToken Create(string subscriptionId, string activityName)
        {
            return new CHkToken
            {
                SubscriptionId = subscriptionId,
                ActivityName = activityName,
                Nonce = Guid.NewGuid().ToString()
            };
        }

        public static CHkToken Decode(string encodedToken)
        {
            var raw = Convert.FromBase64String(encodedToken);
            var json = Encoding.UTF8.GetString(raw);
            return JsonConvert.DeserializeObject<CHkToken>(json);
        }
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        ///  AES 加密
        /// </summary>
        /// <param name="str">明文（待加密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static byte[] AesEncrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Convert.FromBase64String(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return resultArray;
        }

        /// <summary>
        ///  AES 解密
        /// </summary>
        /// <param name="str">明文（待解密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesDecrypt(byte[] str, string key)
        {
            try
            {
                if (str == null) return String.Empty;
                Byte[] toEncryptArray = str;

                RijndaelManaged rm = new RijndaelManaged
                {
                    Key = Convert.FromBase64String(key),
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                ICryptoTransform cTransform = rm.CreateDecryptor();
                Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                CYLogHelper.WriteLog("AesDecrypt异常", ex);
                return String.Empty;
            }

        }
        /// <summary>
        /// 获取UTF-8编码文本的MD5
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetMD5(string text)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
                int length = data.Length;
                for (int i = 0; i < length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return (sb.ToString());
            }
        }

    }
}
