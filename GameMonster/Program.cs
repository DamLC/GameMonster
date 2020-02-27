using System;
using System.Runtime.Remoting.Services;
using System.Security;
using System.Security.Cryptography;
using TPjeu.Niveaux;

namespace TPjeu
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Level1.stage1();

            Narration.choix();
        }
    }
}