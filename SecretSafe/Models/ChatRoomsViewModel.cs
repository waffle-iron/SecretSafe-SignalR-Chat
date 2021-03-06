﻿namespace SecretSafe.Models
{
    using Infrastructure.Mapping;
    using System;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;

    public class ChatRoomsViewModel : IMapFrom<ChatRoom>
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Chat room name is required")]
        [Display(Name = "Chat Room Name")]
        public string ChatRoomName { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int SecurityLevelId { get; set; }

        public string SecurityLevel { get; set; }

        //public void CreateMappings(IConfiguration config)
        //{
        //    config.CreateMap<ChatRoom, ChatRoomsViewModel>("SecurityLevel2")
        //         .ForMember(c => c.SecurityLevel, opt => opt.MapFrom(c => c.SecurityLevels.Name));
        //}
    }
}