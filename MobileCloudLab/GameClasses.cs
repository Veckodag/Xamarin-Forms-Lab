using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MobileCloudLab
{
    public class GameClasses
    {
    }
    public class AwayTeam
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "conference")]
        public string Conference { get; set; }
        [JsonProperty(PropertyName = "division")]
        public string Division { get; set; }
        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }
    }

    public class HomeTeam
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "conference")]
        public string Conference { get; set; }
        [JsonProperty(PropertyName = "division")]
        public string Division { get; set; }
        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }
    }

    public class AwayStat
    {
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }
        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "team_abbreviation")]
        public string TeamAbbreviation { get; set; }
        [JsonProperty(PropertyName = "is_starter")]
        public bool IsStarter { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
    }

    public class HomeStat
    {
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }
        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "team_abbreviation")]
        public string TeamAbbreviation { get; set; }
        [JsonProperty(PropertyName = "is_starter")]
        public bool IsStarter { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
    }

    public class Official
    {
        [JsonProperty(PropertyName = "position")]
        public object Position { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
    }

    public class Site
    {
        [JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }
        [JsonProperty(PropertyName = "surface")]
        public string Surface { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
    }

    public class EventInformation
    {
        [JsonProperty(PropertyName = "temperature")]
        public int Temperature { get; set; }
        [JsonProperty(PropertyName = "site")]
        public Site Site { get; set; }
        [JsonProperty(PropertyName = "attendance")]
        public int Attendance { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "season_type")]
        public string SeasonType { get; set; }
        [JsonProperty(PropertyName = "start_date_time")]
        public string StartTime { get; set; }
    }

    public class AwayTotals
    {
        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
    }

    public class HomeTotals
    {
        [JsonProperty(PropertyName = "minutes")]
        public int Minutes { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
    }

    public class Game
    {
        [JsonProperty(PropertyName = "away_team")]
        public AwayTeam AwayTeam { get; set; }
        [JsonProperty(PropertyName = "home_team")]
        public HomeTeam HomeTeam { get; set; }
        [JsonProperty(PropertyName = "away_period_scores")]
        public List<int> AwayPeriodScores { get; set; }
        [JsonProperty(PropertyName = "home_period_scores")]
        public List<int> HomePeriodScores { get; set; }
        [JsonProperty(PropertyName = "away_stats")]
        public List<AwayStat> AwayStats { get; set; }
        [JsonProperty(PropertyName = "home_stats")]
        public List<HomeStat> HomeStats { get; set; }
        [JsonProperty(PropertyName = "officials")]
        public List<Official> Officials { get; set; }
        [JsonProperty(PropertyName = "event_information")]
        public EventInformation EventInformation { get; set; }
        [JsonProperty(PropertyName = "away_totals")]
        public AwayTotals AwayTotals { get; set; }
        [JsonProperty(PropertyName = "home_totals")]
        public HomeTotals HomeTotals { get; set; }

        public string BoxScore { get; set; } = " ";

        public void SetBoxScore(Game game) 
        { 
            game.BoxScore = $"{game.HomeTeam.Abbreviation} {game.HomeTotals.Points} - {game.AwayTotals.Points} {game.AwayTeam.Abbreviation}";
        }
    }

    public class Team
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "conference")]
        public string Conference { get; set; }
        [JsonProperty(PropertyName = "division")]
        public string Division { get; set; }
        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }
    }

    public class Stats
    {
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "rebounds")]
        public int Rebounds { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "field_goals_made_per_game")]
        public double FieldGoalsMadePerGame { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted_per_game")]
        public double FieldGoalsAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "field_goals_made_per_game_string")]
        public string FieldGoalsMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted_per_game_string")]
        public string FieldGoalsAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made_per_game")]
        public double ThreePointersMadePerGame { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted_per_game")]
        public double ThreePointersAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made_per_game_string")]
        public string ThreePointersMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted_per_game_string")]
        public string ThreePointersAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "free_throws_made_per_game")]
        public double FreeThrowsMadePerGame { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted_per_game")]
        public double FreeThrowsAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "free_throws_made_per_game_string")]
        public string FreeThrowsMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted_per_game_string")]
        public string FreeThrowsAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds_per_game")]
        public double OffensiveReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds_per_game")]
        public double DefensiveReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds_per_game_string")]
        public string OffensiveReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds_per_game_string")]
        public string DefensiveReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "rebounds_per_game_string")]
        public string ReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "assists_per_game_string")]
        public string AssistsPerGameString { get; set; }
        [JsonProperty(PropertyName = "steals_per_game_string")]
        public string StealsPerGameString { get; set; }
        [JsonProperty(PropertyName = "blocks_per_game_string")]
        public string BlocksPerGameString { get; set; }
        [JsonProperty(PropertyName = "turnovers_per_game_string")]
        public string TurnoversPerGameString { get; set; }
        [JsonProperty(PropertyName = "personal_fouls_per_game_string")]
        public string PersonalFoulsPerGameString { get; set; }
        [JsonProperty(PropertyName = "points_per_game_string")]
        public string PointsPerGameString { get; set; }
        [JsonProperty(PropertyName = "rebounds_per_game")]
        public double ReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage_string")]
        public string FieldGoalPercentageString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goal_percentage_string")]
        public string ThreePointerPercentageString { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage_string")]
        public string FreeThrowPercentageString { get; set; }
    }

    public class StatsOpponent
    {
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }
        [JsonProperty(PropertyName = "turnovers")]
        public int Turnovers { get; set; }
        [JsonProperty(PropertyName = "steals")]
        public int Steals { get; set; }
        [JsonProperty(PropertyName = "blocks")]
        public int Blocks { get; set; }
        [JsonProperty(PropertyName = "rebounds")]
        public int Rebounds { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted")]
        public int FieldGoalsAttempted { get; set; }
        [JsonProperty(PropertyName = "field_goals_made")]
        public int FieldGoalsMade { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted")]
        public int ThreePointersAttempted { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made")]
        public int ThreePointersMade { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted")]
        public int FreeThrowsAttempted { get; set; }
        [JsonProperty(PropertyName = "free_throws_made")]
        public int FreeThrowsMade { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds")]
        public int DefensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds")]
        public int OffensiveRebounds { get; set; }
        [JsonProperty(PropertyName = "personal_fouls")]
        public int PersonalFouls { get; set; }
        [JsonProperty(PropertyName = "field_goals_made_per_game")]
        public double FieldGoalsMadePerGame { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted_per_game")]
        public double FieldGoalsAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "field_goals_made_per_game_string")]
        public string FieldGoalsMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "field_goals_attempted_per_game_string")]
        public string FieldGoalsAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made_per_game")]
        public double ThreePointersMadePerGame { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted_per_game")]
        public double ThreePointersAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_made_per_game_string")]
        public string ThreePointersMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goals_attempted_per_game_string")]
        public string ThreePointersAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "free_throws_made_per_game")]
        public double FreeThrowsMadePerGame { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted_per_game")]
        public double FreeThrowsAttemptedPerGame { get; set; }
        [JsonProperty(PropertyName = "free_throws_made_per_game_string")]
        public string FreeThrowsMadePerGameString { get; set; }
        [JsonProperty(PropertyName = "free_throws_attempted_per_game_string")]
        public string FreeThrowsAttemptedPerGameString { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds_per_game")]
        public double OffensiveReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds_per_game")]
        public double DefensiveReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "offensive_rebounds_per_game_string")]
        public string OffensiveReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "defensive_rebounds_per_game_string")]
        public string DefensiveReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "rebounds_per_game_string")]
        public string ReboundsPerGameString { get; set; }
        [JsonProperty(PropertyName = "assists_per_game_string")]
        public string AssistsPerGameString { get; set; }
        [JsonProperty(PropertyName = "steals_per_game_string")]
        public string StealsPerGameString { get; set; }
        [JsonProperty(PropertyName = "blocks_per_game_string")]
        public string BlocksPerGameString { get; set; }
        [JsonProperty(PropertyName = "turnovers_per_game_string")]
        public string TurnoversPerGameString { get; set; }
        [JsonProperty(PropertyName = "personal_fouls_per_game_string")]
        public string PersonalFoulsPerGameString { get; set; }
        [JsonProperty(PropertyName = "points_per_game_string")]
        public string PointsPerGameString { get; set; }
        [JsonProperty(PropertyName = "rebounds_per_game")]
        public double ReboundsPerGame { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage")]
        public double FieldGoalPercentage { get; set; }
        [JsonProperty(PropertyName = "three_point_percentage")]
        public double ThreePointPercentage { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage")]
        public double FreeThrowPercentage { get; set; }
        [JsonProperty(PropertyName = "field_goal_percentage_string")]
        public string FieldGoalPercentageString { get; set; }
        [JsonProperty(PropertyName = "three_point_field_goal_percentage_string")]
        public string ThreePointerPercentageString { get; set; }
        [JsonProperty(PropertyName = "free_throw_percentage_string")]
        public string FreeThrowPercentageString { get; set; }
    }

    public class TeamStat
    {
        [JsonProperty(PropertyName = "team")]
        public Team Team { get; set; }
        [JsonProperty(PropertyName = "games_played")]
        public int GamesPlayed { get; set; }
        [JsonProperty(PropertyName = "won")]
        public int Won { get; set; }
        [JsonProperty(PropertyName = "lost")]
        public int Lost { get; set; }
        [JsonProperty(PropertyName = "stats")]
        public Stats Stats { get; set; }
        [JsonProperty(PropertyName = "stats_opponent")]
        public StatsOpponent StatsOpponent { get; set; }
    }

    public class NBATeam
    {
        [JsonProperty(PropertyName = "sport")]
        public string sport { get; set; }
        [JsonProperty(PropertyName = "team_stats_date")]
        public string TeamStatsDate { get; set; }
        [JsonProperty(PropertyName = "team_stats")]
        public List<TeamStat> TeamStats { get; set; }
    }

    public class Event
    {
        [JsonProperty(PropertyName = "event_id")]
        public string EventID { get; set; }
        [JsonProperty(PropertyName = "event_status")]
        public string EventStatus { get; set; }
        [JsonProperty(PropertyName = "sport")]
        public string Sport { get; set; }
        [JsonProperty(PropertyName = "start_date_time")]
        public string StartDateTime { get; set; }
        [JsonProperty(PropertyName = "season_type")]
        public string SeasonType { get; set; }
        [JsonProperty(PropertyName = "away_team")]
        public AwayTeam AwayTeam { get; set; }
        [JsonProperty(PropertyName = "home_team")]
        public HomeTeam HomeTeam { get; set; }
        [JsonProperty(PropertyName = "site")]
        public Site Site { get; set; }
        [JsonProperty(PropertyName = "away_period_scores")]
        public List<int> AwayPeriodScores { get; set; }
        [JsonProperty(PropertyName = "home_period_scores")]
        public List<int> HomePeriodScores { get; set; }
        [JsonProperty(PropertyName = "away_points_scored")]
        public int AwayPointsScored { get; set; }
        [JsonProperty(PropertyName = "home_points_scored")]
        public int HomePointsScored { get; set; }
    }

    public class Events
    {
        [JsonProperty(PropertyName = "events_date")]
        public string EventsDate { get; set; }
        [JsonProperty(PropertyName = "@event")]
        public List<Event> EventList { get; set; }
    }

    public class Standing
    {
        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }
        [JsonProperty(PropertyName = "won")]
        public int Won { get; set; }
        [JsonProperty(PropertyName = "lost")]
        public int Lost { get; set; }
        [JsonProperty(PropertyName = "streak")]
        public string Streak { get; set; }
        [JsonProperty(PropertyName = "ordinal_rank")]
        public string OrdinalRank { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        [JsonProperty(PropertyName = "games_back")]
        public double GamesBehind { get; set; }
        [JsonProperty("points_for")]
        public int PointsFor { get; set; }
        [JsonProperty("points_against")]
        public int PointsAgainst { get; set; }
        [JsonProperty("home_won")]
        public int HomeWon { get; set; }
        [JsonProperty("home_lost")]
        public int HomeLost { get; set; }
        [JsonProperty("away_won")]
        public int AwayWon { get; set; }
        [JsonProperty("away_lost")]
        public int AwayLost { get; set; }
        [JsonProperty("conference_won")]
        public int ConferenceWon { get; set; }
        [JsonProperty("conference_lost")]
        public int ConferenceLost { get; set; }
        [JsonProperty("last_five")]
        public string LastFive { get; set; }
        [JsonProperty("last_ten")]
        public string LastTen { get; set; }
        [JsonProperty("conference")]
        public string Conference { get; set; }
        [JsonProperty("division")]
        public string Division { get; set; }
        [JsonProperty("playoff_seed")]
        public int PlayoffSeed { get; set; }
        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }
        [JsonProperty("point_differential")]
        public int PointDifferential { get; set; }
        [JsonProperty("point_differential_per_game")]
        public string PointDifferentialPerGame { get; set; }
        [JsonProperty("streak_type")]
        public string StreakType { get; set; }
        [JsonProperty("streak_total")]
        public int StreakTotal { get; set; }
        [JsonProperty("points_scored_per_game")]
        public string PointsScoredPerGame { get; set; }
        [JsonProperty("points_allowed_per_game")]
        public string PointsAllowedPerGame { get; set; }
        [JsonProperty("win_percentage")]
        public string WinPercentage { get; set; }
    }

    public class Standings
    {
        [JsonProperty(PropertyName = "standings_date")]
        public DateTime StandingsDate { get; set; }
        [JsonProperty(PropertyName = "standing")]
        public IList<Standing> StandingList { get; set; }
    }
}
