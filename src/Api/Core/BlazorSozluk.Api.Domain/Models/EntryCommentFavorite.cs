using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryCommentFavorite : BaseEntity
    {
        public Guid EntryCommentId { get; set; }
        public Guid CreatedById { get; set; }


        public EntryComment EntryComment { get; set; }
        public User CreatedUser { get; set; }
    }
}
