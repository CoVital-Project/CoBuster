﻿using System;
using System.Collections.Generic;
using System.Threading;
using CoBuster.ViewModels;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace CoBuster.Views
{
	public partial class CameraPage : ContentPage
	{
		CameraViewModel viewModel;

		public CameraPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new CameraViewModel();

			cameraView.OnAvailable += (_, available) => btnStart.IsEnabled = available;

			cameraView.PreviewAvailabe += (_, e) =>
					viewModel.PreviewCallback(e.Data, e.PreviewSize);

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		
			Analytics.TrackEvent($"Visiting Checks Page");
		}
	}
}
