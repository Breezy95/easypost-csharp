using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EasyPost.Utilities.Internal.Attributes;

namespace EasyPost.Parameters.Batch
{
    /// <summary>
    ///     <a href="https://www.easypost.com/docs/api#remove-shipments-from-a-batch">Parameters</a> for <see cref="EasyPost.Services.BatchService.RemoveShipments(string, RemoveShipments, System.Threading.CancellationToken)"/> API calls.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class RemoveShipments : BaseParameters
    {
        #region Request Parameters

        /// <summary>
        ///     List of <see cref="Models.API.Shipment"/>s to remove from the <see cref="Models.API.Batch"/>.
        /// </summary>
        [TopLevelRequestParameter(Necessity.Optional, "shipments")]
        public List<Models.API.Shipment>? Shipments { get; set; } // Shipments have to exist before they can be removed from a batch

        #endregion
    }
}
