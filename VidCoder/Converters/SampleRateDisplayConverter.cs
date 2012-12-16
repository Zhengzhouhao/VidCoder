﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace VidCoder.Converters
{
	using Resources;

	public class SampleRateDisplayConverter : IValueConverter
	{
		private static Dictionary<int, string> rateDisplayTable = new Dictionary<int, string>
		{
			{0, EncodingRes.SameAsSource},
			{8000, "8 kHz"},
			{11025, "11.025 kHz"},
			{12000, "12 kHz"},
			{16000, "16 kHz"},
			{22050, "22.05 kHz"},
			{24000, "24 kHz"},
			{32000, "32 kHz"},
			{44100, "44.1 kHz"},
			{48000, "48 kHz"}
		};

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return string.Empty;
			}

			if (!(value is int))
			{
				return string.Empty;
			}

			int sampleRate = (int)value;

			return rateDisplayTable[sampleRate];
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
