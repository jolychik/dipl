using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProgUP.classes
{
    static public class CheckStuff
    {
        /// <summary>
        /// Проверка на заполненные поля авторизации
        /// </summary>
        /// <param name="log">для логина</param>
        /// <param name="pass">вы не поверите, это для пароля</param>
        static public void LogAndPasEmpty(string log, string pass)
        {
            if ((string.IsNullOrEmpty(log)) || (string.IsNullOrEmpty(pass)))
            {
                System.Windows.Forms.MessageBox.Show("Заполните все поля!");
            }

        }
        /// <summary>
        /// Проверка на кооректность введённой почты
        /// </summary>
        /// <param name="email">Поле для Email</param>
        /// <returns>false - ошибка</returns>
        static public bool EmailCorrect(string email)
        {
            string maska = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, maska))
            {
                if (Regex.Replace(email, maska, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Ограничение на ввод только букв кириллицы
        /// </summary>
        /// <param name="e">просто параметр для события</param>
        static public void KirillicLatters(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8) && (e.KeyChar != (int)Keys.Space))
            e.Handled = true;
        }
        /// <summary>
        /// Ограничение на ввод только букв латиницы
        /// </summary>
        /// <param name="e">просто параметр для события</param>
        static public void LatinLatters(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && (e.KeyChar != 8) && (e.KeyChar != (int)Keys.Space))
                e.Handled = true;
        }
        /// <summary>
        /// Ограничение на ввод только цифр
        /// </summary>
        /// <param name="e">просто параметр для события</param>
        static public void Numbers(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || Char.IsControl(e.KeyChar) || (e.KeyChar == '+'))
                return;

            e.Handled = true;
        }
        /// <summary>
        /// Ограничение на ввод только букв латиницы и цифр
        /// </summary>
        /// <param name="e">просто параметр для события</param>
        static public void LatinAndNumbers(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'z')
                return;

            e.Handled = true;
        }
        /// <summary>
        /// Ограничение на ввод только букв кириллицы и цифр
        /// </summary>
        /// <param name="e">просто параметр для события</param>
        static public void KirillicAndNumbers(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar < 'А' || e.KeyChar > 'я')
                return;

            e.Handled = true;
        }
    }
}
