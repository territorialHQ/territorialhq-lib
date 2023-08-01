using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using TerritorialHQ_Library.DTO;
using TerritorialHQ_Library.DTO.Interface;

namespace TerritorialHQ_Library.Entities;

public class Clan : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Creator { get; set; }

    public string? Name { get; set; }
    public ulong? GuildId { get; set; }
    public string? Foundation { get; set; }
    public string? Founders { get; set; }
    public string? Tag { get; set; }
    public string? Motto { get; set; }
    public string? Color1 { get; set; }
    public string? Color2 { get; set; }
    public string? BotEndpoint { get; set; }
    public string? LogoFile { get; set; }
    public string? BannerFile { get; set; }
    public string? DiscordLink { get; set; }
    public string? Description { get; set; }
    public string? History { get; set; }
    public string? Community { get; set; }
    public string? Features { get; set; }
    public string? Miscellaneous { get; set; }
    public bool IsPublished { get; set; }
    public bool InReview { get; set; }

    public virtual List<ClanUserRelation> ClanUserRelations { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOClan
        {
            Id = this.Id,
            Timestamp = this.Timestamp,
            Creator = this.Creator,
            Name = this.Name,
            GuildId = this.GuildId,
            Foundation = this.Foundation,
            Founders = this.Founders,
            Motto = this.Motto,
            Color1 = this.Color1,
            Color2 = this.Color2,
            Tag = this.Tag,
            BotEndpoint = this.BotEndpoint,
            LogoFile = this.LogoFile,
            BannerFile = this.BannerFile,
            DiscordLink = this.DiscordLink,
            Description = this.Description,
            History = this.History,
            Community = this.Community,
            Features = this.Features,
            Miscellaneous = this.Miscellaneous,
            IsPublished = this.IsPublished,
            InReview = this.InReview,

            AssignedAppUsers = this.ClanUserRelations?.Select(r => new DTOClanUserRelation()
            {
                Id = r.AppUser!.Id,
                AppUserId = r.AppUser!.Id,
                AppDiscordId = r.AppUser!.DiscordId,
                AppUserName = r.AppUser!.UserName,
                Role = r.AppUser!.Role
            })?.ToList() ?? new()
        };

        return dto;
    }

    public void MapDto(IDto dto)
    {
        var clan = (DTOClan)dto;

        this.Timestamp = clan.Timestamp;
        this.Creator = clan.Creator;
        this.Name = clan.Name;
        this.GuildId = clan.GuildId;
        this.Foundation = clan.Foundation;
        this.Founders = clan.Founders;
        this.Motto = clan.Motto;
        this.Color1 = clan.Color1;
        this.Color2 = clan.Color2;
        this.Tag = clan.Tag;
        this.BotEndpoint = clan.BotEndpoint;
        this.LogoFile = clan.LogoFile;
        this.BannerFile = clan.BannerFile;
        this.DiscordLink = clan.DiscordLink;
        this.Description = clan.Description;
        this.History = clan.History;
        this.Community = clan.Community;
        this.Features = clan.Features;
        this.Miscellaneous = clan.Miscellaneous;
        this.IsPublished = clan.IsPublished;
        this.InReview = clan.InReview;
    }

    public DTOClanListEntry GetDtoListEntry()
    {
        var dto = new DTOClanListEntry
        {
            Id = this.Id,
            Name = this.Name,
            Motto = this.Motto,
            Color1 = this.Color1,
            Color2 = this.Color2,
            Tag = this.Tag,
            LogoFile = this.LogoFile,
            DiscordLink = this.DiscordLink,
            IsPublished = this.IsPublished,
            InReview = this.InReview
        };

        return dto;
    }
}