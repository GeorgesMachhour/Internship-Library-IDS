CREATE PROCEDURE [dbo].[spPublisher_GetAll]
AS
begin
	select PublisherId, PublisherName, PublisherEmail, PublisherPhone 
	from dbo.[Publisher];
end
