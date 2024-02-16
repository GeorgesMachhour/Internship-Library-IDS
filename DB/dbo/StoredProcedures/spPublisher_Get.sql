CREATE PROCEDURE [dbo].[spPublisher_Get]
	@PublisherId int
AS
begin
	select PublisherId, PublisherName, PublisherEmail, PublisherPhone
	from dbo.[Publisher]
	where PublisherId = @PublisherId;
end
