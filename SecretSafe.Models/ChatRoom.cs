﻿namespace SecretSafe.Models
{
    using global::Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name:"ChatRooms")]
    public class ChatRoom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        
        public string UserId { get; set; }

        public int SecurityLevelId { get; set; }

        public string ChatRoomName { get; set; }


        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public virtual SecretSafeUser User { get; set; }

        public virtual SecurityLevel SecurityLevels { get; set; }
    }
}
