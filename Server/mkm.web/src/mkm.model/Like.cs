﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mkm.model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Like
    {
        public long Id { get; set; }

        public TimeSpan Created { get; set; }

        public string LikeType { get; set; }

        public long ApplicationUserId { get; set; }

        public ApplicationUser User { get; set; }

        public long PostId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
