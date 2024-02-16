CREATE PROCEDURE [dbo].[spPublisher_Delete]
	@PublisherId int
AS
begin
	delete
	from dbo.[Publisher]
	where PublisherId = @PublisherId;
end
