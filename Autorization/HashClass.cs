using System;
using System.Windows.Forms;

namespace Autorization
{
    class HashClass
    {
        public string hashlogin(string login)
        {
            try
            {
                string tb1;
                if (Properties.Settings.Default.isAutoEnter == true)
                {
                    tb1 = Properties.Settings.Default.deafLog;
                }
                else
                {
                    tb1 = login;
                }
                string key = "8948761623215";
                string cppalfavit = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                    "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬ" +
                    "ЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefghijklmnopqrstuvwxyzABCDEFGHIJK" +
                    "LMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРС" +
                    "ТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefghijklmnopqrstuvwxyzAB" +
                    "CDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙ" +
                    "КЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefghijklmnopqrstu" +
                    "vwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГД" +
                    "ЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefghijklmnopq" +
                    "rstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВ" +
                    "ГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefghijklmnop" +
                    "qrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБ" +
                    "ВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.";
                string keyaccept = "";
                string otvet = "";
                int dopler = 0;

                if (key.Length != tb1.Length)
                    if (key.Length > tb1.Length)
                        keyaccept = key.Remove(tb1.Length);
                    else
                    {
                        double multip = tb1.Length / key.Length;
                        int help = (int)(Math.Ceiling(multip));
                        for (int jg = 1; jg <= help; jg++)
                            key += key;
                        if (key.Length > tb1.Length)
                            keyaccept = key.Remove(tb1.Length);
                        else keyaccept = key;
                    }
                else
                    keyaccept = key;

                for (int bv = 0; bv < tb1.Length; bv++)
                {
                    if (dopler == 2)
                    {
                        otvet += cppalfavit[cppalfavit.IndexOf(tb1[bv]) + keyaccept[bv] + 2 + bv];
                        dopler = 0;
                    }
                    if (dopler != 2)
                        otvet += cppalfavit[cppalfavit.IndexOf(tb1[bv]) + keyaccept[bv] + 13 + bv];
                    dopler++;
                }

                return otvet;
            }
            catch
            {
                MessageBox.Show("Что то пошло не так при загрузке логина!", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string hashpass(string pass)
        {
            try
            {
                string tb2;
                if (Properties.Settings.Default.isAutoEnter == true)
                    tb2 = Properties.Settings.Default.deafPass;
                else tb2 = pass;
                string key = "6435823475021";
                string cppalfavit = "7890!@#$%^&*()_+=-?abcdefghijABCDEFGHIJKLMNOPQRst" +
                    "uvwxyzклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234" +
                    "56klmnopqrSTUVWXYZабвгдеёжзий.abcdefghijklmnopqrstuvwxyzABCDEFGHI" +
                    "JKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМ(" +
                    ")_+=-?.abcdefghijkНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*lmnopqrstu" +
                    "vwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяА" +
                    "БВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.abcdefg" +
                    "hijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрст" +
                    "уфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*(" +
                    ")_+=-?.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгде" +
                    "ёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ12345" +
                    "67890!@#$%^&*()_+=-?.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQR" +
                    "STUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦ" +
                    "ЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.";
                string keyaccept = "";
                string otvet = "";
                int dopler = 0;

                if (key.Length != tb2.Length)
                    if (key.Length > tb2.Length)
                        keyaccept = key.Remove(tb2.Length);
                    else
                    {
                        double multip = tb2.Length / key.Length;
                        int help = (int)(Math.Ceiling(multip));
                        for (int jg = 1; jg <= help; jg++)
                            key += key;
                        if (key.Length > tb2.Length)
                            keyaccept = key.Remove(tb2.Length);
                        else keyaccept = key;
                    }
                else
                    keyaccept = key;

                for (int bv = 0; bv < tb2.Length; bv++)
                {
                    if (dopler == 1)
                    {
                        otvet += cppalfavit[cppalfavit.IndexOf(tb2[bv]) + keyaccept[bv] + 2 + bv];
                        dopler = 0;
                    }
                    if (dopler != 1)
                        otvet += cppalfavit[cppalfavit.IndexOf(tb2[bv]) + keyaccept[bv] + 13 + bv];
                    dopler++;
                }

                return otvet;
            } catch
            {
                MessageBox.Show("Что то пошло не так при загрузке пароля!", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string codeparse(string code)
        {
            try
            {
                string hashcode = code;
                string otthat = hashcode;
                hashcode += 2;
                int config = Convert.ToInt32(hashcode);
                hashcode = "";
                for (int b = 2; b < 4; b++)
                {
                    config += 13 * config - 3 - config * (b + 3);
                    config = config * b + b;
                }
                string conf = Convert.ToString(config);
                for (int i = 1; i < 6; i++)
                    hashcode += conf[i];
                int cc = 0;
                for (cc = 0; cc < hashcode.Length; cc++)
                {
                    if (hashcode[cc] == '0')
                        continue;
                    else
                        break;
                }
                hashcode = hashcode.Remove(0, cc);
                return hashcode;
            }
            catch
            {
                MessageBox.Show("Что то пошло не так при загрузке секретного кода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string hashemail(string email)
        {
            try
            {
                string tb3 = email;
                string key = "48719354347221";
                string cppalfavit = "уфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПнопрстбвгдеёжзий.abcdef" +
                    "ghijklИЙКЛМ()_+=-?.abcdefghijkНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*lm" +
                    "mnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъы" +
                    "ьэюяАБВГДЕЁЖЗnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмноп" +
                    "рстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ123456789pqrstuvwxyz" +
                    "ABCDEFстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩG90!@HIJKLMNOPQRSTUVW" +
                    "XYZабвгдеёжзийклмнопрЪЫЬЭЮЯ12345678#$%^&*()_+=-?.abcdefghijkl0!@#$%^&" +
                    "*()_+=-?.abcdefghijжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦ" +
                    "ЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+РСТУ90!@#$%^&*()_ФХЦЧШЩЪЫЬЭЮЯ123456klm" +
                    "nopqrSTUVWXYZа78+=-?abcdefghiklmnomnopqrstuvwxyzABCDEFGHIJKLMN1234567" +
                    "8ZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩ90!@#$%" +
                    "^&OPQRSTUVWXYЪЫЬЭЮЯ*()_+=-?.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNO" +
                    "PQRSTUVWXYZабвгдеёjABCDEFGHIJKLMNOPQRstuvwxyzклм=-?.";
                string keyaccept = "";
                string otvet = "";
                int dopler = 0;

                if (key.Length != tb3.Length)
                    if (key.Length > tb3.Length)
                        keyaccept = key.Remove(tb3.Length);
                    else
                    {
                        double multip = tb3.Length / key.Length;
                        int help = (int)(Math.Ceiling(multip));
                        for (int jg = 1; jg <= help; jg++)
                            key += key;
                        if (key.Length > tb3.Length)
                            keyaccept = key.Remove(tb3.Length);
                        else keyaccept = key;
                    }
                else
                    keyaccept = key;

                for (int bv = 0; bv < tb3.Length; bv++)
                {
                    if (dopler == 1)
                    {
                        otvet += cppalfavit[cppalfavit.IndexOf(tb3[bv]) + keyaccept[bv] + 2 + bv];
                        dopler = 0;
                    }
                    if (dopler != 1)
                        otvet += cppalfavit[cppalfavit.IndexOf(tb3[bv]) + keyaccept[bv] + 13 + bv];
                    dopler++;
                }

                return otvet;
            }
            catch
            {
                MessageBox.Show("Что то пошло не так при загрузке Email!", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string EncryptBase(string text)
        {
            try
            {
                string alphabet =
                "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                string keyaccept = "";
                string otvet = "";
                string key = "bvylivv9714s";
                string keys = "";

                if (key.Length != text.Length)
                    if (key.Length > text.Length)
                        keyaccept = key.Remove(text.Length);
                    else
                    {
                        double multip = text.Length / key.Length;
                        int help = (int)(Math.Ceiling(multip));
                        for (int jg = 1; jg <= help + 1; jg++)
                            keys += key;
                        if (keys.Length > text.Length)
                            keyaccept = keys.Remove(text.Length);
                        else keyaccept = keys;
                    }
                else
                    keyaccept = key;

                for (int i = 0; i < text.Length; i++)
                {
                    if (!alphabet.Contains(Convert.ToString(text[i])))
                    {
                        otvet += text[i];
                        continue;
                    }
                    otvet += alphabet[alphabet.IndexOf(text[i]) + alphabet.IndexOf(keyaccept[i])];
                }

                return otvet;
            }
            catch
            {
                MessageBox.Show("При шифровке возникла ошибка!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }

        public string DencryptBase(string text)
        {
            try
            {
                string alphabet =  // 133 * 3 = 399
                 "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                 "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                 "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                 "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                 "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ%*" +
                 "?@#$абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

                string keyaccept = "";
                string otvet = "";
                string key = "bvylivv9714s";
                string keys = "";

                if (key.Length != text.Length)
                    if (key.Length > text.Length)
                        keyaccept = key.Remove(text.Length);
                    else
                    {
                        double multip = text.Length / key.Length;
                        int help = (int)(Math.Ceiling(multip));
                        for (int jg = 1; jg <= help + 1; jg++)
                            keys += key;
                        if (keys.Length > text.Length)
                            keyaccept = keys.Remove(text.Length);
                        else keyaccept = keys;
                    }
                else
                    keyaccept = key;

                for (int i = 0; i < text.Length; i++)
                {
                    if (!alphabet.Contains(Convert.ToString(text[i])))
                    {
                        otvet += text[i];
                        continue;
                    }
                    otvet += alphabet[266 + alphabet.IndexOf(text[i]) - alphabet.IndexOf(keyaccept[i])];
                }

                return otvet;
            }
            catch
            {
                MessageBox.Show("При дешифровке возникла ошибка!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }
    }
}
