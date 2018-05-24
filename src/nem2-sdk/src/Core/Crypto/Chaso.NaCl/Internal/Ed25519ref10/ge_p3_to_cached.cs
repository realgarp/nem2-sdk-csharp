﻿namespace io.nem2.sdk.Core.Crypto.Chaso.NaCl.Internal.Ed25519ref10
{
	internal static partial class GroupOperations
	{
		/*
		r = p
		*/
		internal static void ge_p3_to_cached(out GroupElementCached r, ref GroupElementP3 p)
		{
			FieldOperations.fe_add(out r.YplusX, ref p.Y, ref p.X);
			FieldOperations.fe_sub(out r.YminusX, ref p.Y, ref p.X);
			r.Z = p.Z;
			FieldOperations.fe_mul(out r.T2d, ref p.T, ref LookupTables.d2);
		}
	}
}