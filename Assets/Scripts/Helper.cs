using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper {
    public static void LookTowards(Transform transform, Vector3 target) {
        Vector3 direction = (target - transform.position).normalized;
        //create the rotation we need to be in to look at the target
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        //rotate us over time according to speed until we are in the required rotation
        transform.rotation = lookRotation;
    }
}