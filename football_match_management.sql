create database FootballMatchManagement;
use FootballMatchManagement;

-- users --
create table users ( username  varchar(255) primary key  , password varchar(255))
insert into users values ( 'admin', 'admin');
drop table users
select * from users
-- Matches --
CREATE TABLE Matches (
  MatchID INT PRIMARY KEY ,  -- Use IDENTITY instead of AUTO_INCREMENT
  Date DATE,
  Time TIME,
  Venue VARCHAR(255),
  HomeTeamID INT,
  AwayTeamID INT,
  HomeTeamScore INT,
  AwayTeamScore INT,
  FinalScore varchar(255),
  FOREIGN KEY (HomeTeamID) REFERENCES Teams(TeamID),
  FOREIGN KEY (AwayTeamID) REFERENCES Teams(TeamID)
);

-- Teams --

CREATE TABLE Teams (
  TeamID INT PRIMARY key ,  -- Use IDENTITY instead of AUTO_INCREMENT
  TeamName VARCHAR(255) NOT NULL,
  CoachName VARCHAR(255)
);

-- Goals --
CREATE TABLE Goals (
  GoalID INT PRIMARY key  ,  -- Use IDENTITY instead of AUTO_INCREMENT
  MatchID INT,
  NamePlayer varchar(255),
  Minute INT,
  FOREIGN KEY (MatchID) REFERENCES Matches(MatchID),
  
);
delete from Goals
drop table Goals


-- insert values 
INSERT INTO Teams (TeamName, CoachName)
VALUES ('Real Madrid', 'Carlo Ancelotti'),
       ('FC Barcelona', 'Xavi Hernandez'),
       ('Manchester United', 'Erik ten Hag');


INSERT INTO Matches (Date, Time, Venue, HomeTeamID, AwayTeamID, HomeTeamScore, AwayTeamScore, FinalScore)
VALUES ('2024-03-10', '18:00:00', 'Santiago Bernabéu', 1, 2, 2, 1, '3-1'),  -- Real Madrid vs. FC Barcelona
       ('2024-03-11', '15:00:00', 'Old Trafford', 3, 1, 1, 0, '1-0'),  -- Manchester United vs. Real Madrid
       ('2024-03-12', '20:00:00', 'Camp Nou', 2, 3, 0, 3, '0-3');   -- FC Barcelona vs. Manchester United


	   INSERT INTO Goals (MatchID, Minute)
VALUES (1, 25),  -- Goal in Real Madrid vs. FC Barcelona (MatchID 1)
       (1, 70),  -- Another goal in Real Madrid vs. FC Barcelona (MatchID 1)
       (1, 85),  -- Goal in Real Madrid vs. FC Barcelona (MatchID 1)
       (2, 60);   -- Goal in Manchester United vs. Real Madrid (MatchID 2)
select * from users	   
select * from Teams
select * from Matches
select * from Goals
-- Proc search Matches with HomeTeamID --
CREATE PROCEDURE GetMatchesWithTeamNames(@HomeTeamID varchar(255))
AS
BEGIN
    SELECT 
        M.Date,
        M.Time,
        M.Venue,
        M.HomeTeamID,
        HomeTeam.TeamName AS HomeTeamName,
        M.AwayTeamID,
        AwayTeam.TeamName AS AwayTeamName,
        M.HomeTeamScore,
        M.AwayTeamScore,
        M.FinalScore
    FROM 
        Matches M
    INNER JOIN 
        Teams HomeTeam ON M.HomeTeamID = HomeTeam.TeamID
    INNER JOIN 
        Teams AwayTeam ON M.AwayTeamID = AwayTeam.TeamID
    WHERE 
        M.HomeTeamID LIKE @HomeTeamID
END;
-- Proc search Matches with AwayTeamID --

CREATE PROCEDURE GetMatchesWithTeamNames1(@AwayTeamID varchar(255))
AS
BEGIN
    SELECT 
        M.Date,
        M.Time,
        M.Venue,
        M.HomeTeamID,
        HomeTeam.TeamName AS HomeTeamName,
        M.AwayTeamID,
        AwayTeam.TeamName AS AwayTeamName,
        M.HomeTeamScore,
        M.AwayTeamScore,
        M.FinalScore
    FROM 
        Matches M
    INNER JOIN 
        Teams HomeTeam ON M.HomeTeamID = HomeTeam.TeamID
    INNER JOIN 
        Teams AwayTeam ON M.AwayTeamID = AwayTeam.TeamID
    WHERE 
        M.AwayTeamID LIKE @AwayTeamID
END;

-- Thêm dữ liệu vào bảng Teams
INSERT INTO Teams (TeamID, TeamName, CoachName)
VALUES 
(1, 'Real Madrid', 'Carlo Ancelotti'),
(2, 'FC Barcelona', 'Xavi Hernandez'),
(3, 'Manchester United', 'Erik ten Hag'),
(4, 'Liverpool FC', 'Jürgen Klopp'),
(5, 'Bayern Munich', 'Julian Nagelsmann'),
(6, 'Paris Saint-Germain', 'Mauricio Pochettino'),
(7, 'Juventus', 'Massimiliano Allegri'),
(8, 'Chelsea FC', 'Thomas Tuchel'),
(9, 'AC Milan', 'Stefano Pioli'),
(10, 'Manchester City', 'Pep Guardiola');

-- Thêm dữ liệu vào bảng Matches
INSERT INTO Matches (MatchID, Date, Time, Venue, HomeTeamID, AwayTeamID, HomeTeamScore, AwayTeamScore, FinalScore)
VALUES 
(1, '2024-03-01', '18:00:00', 'Santiago Bernabéu', 1, 2, 2, 1, '3-1'), -- Real Madrid vs. FC Barcelona
(2, '2024-03-02', '15:00:00', 'Old Trafford', 3, 1, 1, 0, '1-0'),     -- Manchester United vs. Real Madrid
(3, '2024-03-03', '20:00:00', 'Camp Nou', 2, 3, 0, 3, '0-3'),         -- FC Barcelona vs. Manchester United
(4, '2024-03-04', '19:00:00', 'Anfield', 4, 5, 2, 2, '2-2'),          -- Liverpool vs. Bayern Munich
(5, '2024-03-05', '21:00:00', 'Parc des Princes', 6, 7, 1, 3, '1-3'), -- PSG vs. Juventus
(6, '2024-03-06', '17:30:00', 'Stamford Bridge', 8, 9, 2, 1, '2-1'),  -- Chelsea vs. AC Milan
(7, '2024-03-07', '20:45:00', 'Etihad Stadium', 10, 1, 3, 0, '3-0'),  -- Manchester City vs. Real Madrid
(8, '2024-03-08', '16:00:00', 'Allianz Arena', 5, 2, 1, 1, '1-1'),    -- Bayern Munich vs. FC Barcelona
(9, '2024-03-09', '14:30:00', 'San Siro', 9, 8, 0, 2, '0-2'),        -- AC Milan vs. Chelsea
(10, '2024-03-10', '19:45:00', 'Anfield', 4, 7, 3, 2, '3-2');        -- Liverpool vs. Juventus

-- Thêm dữ liệu vào bảng Goals
INSERT INTO Goals (GoalID, MatchID, NamePlayer, Minute)
VALUES 
(1, 1, ' Ronaldo', 15),  -- Goal in Real Madrid vs. FC Barcelona
(2, 1, 'Messi', 30),  -- Another goal in Real Madrid vs. FC Barcelona
(3, 2, 'Saka', 45),  -- Goal in Manchester United vs. Real Madrid
(4, 2, 'Sanchez', 60),  -- Another goal in Manchester United vs. Real Madrid
(5, 3, 'Giroud', 20),  -- Goal in FC Barcelona vs. Manchester United
(6, 3, 'Mpbape', 50),  -- Another goal in FC Barcelona vs. Manchester United
(7, 4, 'Sancho', 25),  -- Goal in Liverpool vs. Bayern Munich
(8, 4, 'Theo', 70),  -- Another goal in Liverpool vs. Bayern Munich
(9, 5, 'A Hau', 35),  -- Goal in PSG vs. Juventus
(10, 5, 'Salah', 80); -- Another goal in PSG vs. Juventus

select * from users