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
    public string? Motto { get; set; }
    public string? BotEndpoint { get; set; }
    public string? LogoFile { get; set; }
    public string? BannerFile { get; set; }
    public string? DiscordLink { get; set; }
    public string? Description { get; set; }
    public bool IsPublished { get; set; }
    public bool InReview { get; set; }

    public virtual List<ClanUserRelation> ClanUserRelations { get; set; }

    public IDto GetDto()
    {
        var dto = new DTOClan();

        dto.Id = this.Id;
        dto.Timestamp = this.Timestamp;
        dto.Creator = this.Creator;
        dto.Name = this.Name;
        dto.GuildId = this.GuildId;
        dto.Foundation = this.Foundation;
        dto.Founders = this.Founders;
        dto.Motto = this.Motto;
        dto.BotEndpoint = this.BotEndpoint;
        dto.LogoFile = this.LogoFile;
        dto.BannerFile = this.BannerFile;
        dto.DiscordLink = this.DiscordLink;
        dto.Description = this.Description;
        dto.IsPublished = this.IsPublished;
        dto.InReview = this.InReview;

        dto.AssignedAppUsers = this.ClanUserRelations?.Select(r => new DTOAppUser()
        {
            Id = r.AppUser!.Id,
            DiscordId = r.AppUser!.DiscordId,
            UserName = r.AppUser!.UserName,
            Role = r.AppUser!.Role
        })?.ToList() ?? new();

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
        this.BotEndpoint = clan.BotEndpoint;
        this.LogoFile = clan.LogoFile;
        this.BannerFile = clan.BannerFile;
        this.DiscordLink = clan.DiscordLink;
        this.Description = clan.Description;
        this.IsPublished = clan.IsPublished;
        this.InReview = clan.InReview;
    }
}