using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DomainModel.Interfaces.Repositories;

namespace DigitalizeSocialNetwork.DomainModel.Entities
{
    public class Post : EntityBase
    {
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }

        public DateTime PublishDateTime { get; set; }
        public string Content { get; set; }
    }
}
