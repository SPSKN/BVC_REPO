/*
Course code : DATA1201
Term/Year : Wint2018
Assignment code: GLA5
Author : Scott Patterson	
BVC username :s.patterson528
Date created : 2018-04-05
Description :GLA5
*/


--EX.1

CREATE VIEW sale_view_for_alex AS
SELECT * 
FROM orders
WHERE customer_name = 'Alex';

--EX.2

SELECT *
FROM sale_view_for_alex;

--EX.3
--SQlite does not support the READ-ONLY clause
CREATE VIEW sales
AS
SELECT * FROM orders
WHERE orders.oid > 1;

--EX4
--a

CREATE VIEW ex4a_view AS
SELECT tracks.Trackid AS Track_Id, tracks.Name AS Track_Name, albums.Title AS Album_Title, media_types.Name AS Media_Type, genres.Name AS Genre
FROM tracks
JOIN albums ON albums.AlbumId = tracks.AlbumId
JOIN media_types ON media_types.MediaTypeId = tracks.MediaTypeId
JOIN genres ON genres.GenreId = tracks.GenreId;
--b
CREATE VIEW ex4b_view AS
SELECT tracks.Trackid AS Track_Id, tracks.Name AS Track_Name, albums.Title AS Album_Title, media_types.Name AS Media_Type, genres.Name AS Genre
FROM tracks
JOIN albums ON albums.AlbumId = tracks.AlbumId
JOIN media_types ON media_types.MediaTypeId = tracks.MediaTypeId
JOIN genres ON genres.GenreId = tracks.GenreId
WHERE genres.Name = 'Rock';
--c
CREATE VIEW ex4c_view AS
SELECT tracks.Trackid AS Track_Id, tracks.Name AS Track_Name, albums.Title AS Album_Title, media_types.Name AS Media_Type, genres.Name AS Genre
FROM tracks
JOIN albums ON albums.AlbumId = tracks.AlbumId
JOIN media_types ON media_types.MediaTypeId = tracks.MediaTypeId
JOIN genres ON genres.GenreId = tracks.GenreId
JOIN artists ON artists.ArtistId = albums.ArtistId
WHERE artists.Name = 'Alanis Morissette';
--d
CREATE VIEW ex4d_view AS
SELECT tracks.Name AS Track_Name, albums.Title AS Album_Title, artists.Name AS Artist
FROM playlist_track
JOIN tracks ON tracks.TrackId = playlist_track.TrackId
JOIN albums ON albums.AlbumId = tracks.AlbumId
JOIN artists ON artists.ArtistId = albums.ArtistId
WHERE playlist_track.PlaylistId = '1';