﻿namespace io.nem2.sdk.Core.Crypto.Chaso.NaCl.Internal.Ed25519ref10
{
	internal static partial class GroupOperations
	{
		/*
		r = p
		*/
		internal static void ge_p1p1_to_p2(out GroupElementP2 r, ref GroupElementP1P1 p)
		{
			FieldOperations.fe_mul(out r.X, ref p.X, ref p.T);
			FieldOperations.fe_mul(out r.Y, ref p.Y, ref p.Z);
			FieldOperations.fe_mul(out r.Z, ref p.Z, ref p.T);
		}

	}
}