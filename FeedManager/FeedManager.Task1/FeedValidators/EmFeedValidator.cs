using FeedManager.Task1.Feeds;
using FeedManager.Task1.FeedValidators;

namespace FeedManager.Task1.FeedImporters
{
    public class EmFeedValidator : BaseFeedValidator, IFeedValidator<EmFeed>
    {
        private readonly decimal _minSedolValue = 0;
        private readonly decimal _maxSedolValue = 100;
        private readonly decimal _minAssetValue = 0;

        public ValidateResult Validate(EmFeed feed)
        {
            validateResult = new ValidateResult();
            ValidateIds(feed);
            ValidatePrice(feed);
            ValidateSedol(feed);
            ValidateAssetValue(feed);

            UpdateValidState();

            return validateResult;
        }
        private void ValidateSedol(EmFeed feed)
        {
            if (feed.Sedol <= _minSedolValue || feed.Sedol >= _maxSedolValue)
            {
                validateResult.Errors.Add(ErrorCode.PropertyRangeError(nameof(feed.Sedol), _minSedolValue, _maxSedolValue));
            }
        }

        private void ValidateAssetValue(EmFeed feed)
        {
            if (feed.AssetValue <= _minAssetValue || feed.AssetValue >= feed.Sedol)
            {
                validateResult.Errors.Add(ErrorCode.PropertyRangeError(nameof(feed.AssetValue), _minAssetValue, feed.Sedol));
            }
        }
    }
}
