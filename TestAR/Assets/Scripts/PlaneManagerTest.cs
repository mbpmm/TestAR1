using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlaneManagerTest : MonoBehaviour
{
    //public enum PlaneMode
    //{
    //    GROUND,
    //    MIDAIR,
    //    PLACEMENT
    //}
    //[SerializeField] PlaneFinderBehaviour planeFinder = null;
    //public static PlaneMode CurrentPlaneMode = PlaneMode.PLACEMENT;
    //public static bool GroundPlaneHitReceived { get; private set; }
    //int automaticHitTestFrameCount;
    //static TrackableBehaviour.Status StatusCached = TrackableBehaviour.Status.NO_POSE;
    //static TrackableBehaviour.StatusInfo StatusInfoCached = TrackableBehaviour.StatusInfo.UNKNOWN;

    //public static bool TrackingStatusIsTrackedAndNormal
    //{
    //    get
    //    {
    //        return
    //            (StatusCached == TrackableBehaviour.Status.TRACKED ||
    //             StatusCached == TrackableBehaviour.Status.EXTENDED_TRACKED) &&
    //            StatusInfoCached == TrackableBehaviour.StatusInfo.NORMAL;
    //    }
    //}

    //// Less Strict: Property returns true when Status is Tracked/Normal or Limited/Unknown.
    //public static bool TrackingStatusIsTrackedOrLimited
    //{
    //    get
    //    {
    //        return
    //            ((StatusCached == TrackableBehaviour.Status.TRACKED ||
    //             StatusCached == TrackableBehaviour.Status.EXTENDED_TRACKED) &&
    //             StatusInfoCached == TrackableBehaviour.StatusInfo.NORMAL) ||
    //            (StatusCached == TrackableBehaviour.Status.LIMITED &&
    //             StatusInfoCached == TrackableBehaviour.StatusInfo.UNKNOWN);
    //    }
    //}

    //bool SurfaceIndicatorVisibilityConditionsMet
    //{
    //    // The Surface Indicator should only be visible if the following conditions
    //    // are true:
    //    // 1. Tracking Status is Tracked or Limited (sufficient for Hit Test Anchors
    //    // 2. Ground Plane Hit was received for this frame
    //    // 3. The Plane Mode is equal to GROUND or PLACEMENT(see #4)
    //    // 4. If the Plane Mode is equal to PLACEMENT and *there's no active touches
    //    get
    //    {
    //        return
    //            (TrackingStatusIsTrackedOrLimited &&
    //             GroundPlaneHitReceived &&
    //             (CurrentPlaneMode == PlaneMode.GROUND ||
    //                (CurrentPlaneMode == PlaneMode.PLACEMENT && Input.touchCount == 0)));
    //    }
    //}
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void LateUpdate()
    //{
    //    GroundPlaneHitReceived = (this.automaticHitTestFrameCount == Time.frameCount);

    //    //Debug.Log(GroundPlaneHitReceived);
    //    // Surface Indicator visibility conditions rely upon GroundPlaneHitReceived,
    //    // so we will move this method into LateUpdate() to ensure that it is called
    //    // after GroundPlaneHitReceived has been updated in Update().
    //    //SetSurfaceIndicatorVisible(SurfaceIndicatorVisibilityConditionsMet);
    //}

    //void SetSurfaceIndicatorVisible(bool isVisible)
    //{
    //    Renderer[] renderers = this.planeFinder.PlaneIndicator.GetComponentsInChildren<Renderer>(true);
    //    Canvas[] canvas = this.planeFinder.PlaneIndicator.GetComponentsInChildren<Canvas>(true);

    //    foreach (Canvas c in canvas)
    //        c.enabled = isVisible;

    //    foreach (Renderer r in renderers)
    //        r.enabled = isVisible;
    //}
}
