using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerService
{
    [Serializable]
    [DataContract(IsReference = true)]
    class User
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
