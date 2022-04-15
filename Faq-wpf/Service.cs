using System.Windows.Controls;
using Faq_wpf.Models;

namespace Faq_wpf
{
    public class Service
    {
        public static Context db = new Context();
        private static User clientSession = new User();
        public static Frame frame;
        public static User ClientSession
        {
            get => clientSession;
            set => clientSession = value;

        }
    }
}
