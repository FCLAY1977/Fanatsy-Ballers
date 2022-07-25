using System.ComponentModel.DataAnnotations;



public class FantasyTeam 
{
    
    [Key] 
    
    public int ID {get;set;}
    
    public string? QB1 {get; set;}

    public string? QB2 {get; set;}

    public string? RB1 {get; set;}

    public string? RB2 {get; set;}

    public string? WR1 {get; set;}

    public string? WR2 {get; set;}

    public string? TE {get; set;}

    public string? Flex {get; set;}

    public string? Kicker {get; set;}

    public string? Defense {get; set;}

    public double? SkillLevel {get; set;}

    public int? TouchdownsScoredLastYear {get; set;}

    public int? TouchDownsProjected {get; set;}



}