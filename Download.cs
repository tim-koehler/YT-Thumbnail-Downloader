using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace YouTubeThumbnailDownloader
{
    public static class Downloader
    {
        /// <summary>
        /// Return full size Thumbnail
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Image GetThumbnail(string url)
        {
            string videoIdentifier = GetVideoIdentifier(url);

            if (String.IsNullOrEmpty(videoIdentifier))
                return null;

            Image thumbnail = DownloadThumbnail(videoIdentifier);

            return thumbnail;
        }

        #region Private Methods

        /// <summary>
        /// Downloads the Thumbnail
        /// </summary>
        /// <param name="url"></param>
        /// <returns>Downloaded Thumbnail</returns>
        private static Image DownloadThumbnail(string videoIdentifier)
        {
            WebClient webClient = new WebClient();

            Stream memStream = null;

            try
            {
                try
                {
                    memStream = webClient.OpenRead(BuildThumbnailUrl(videoIdentifier, Type.Maxres));
                }
                catch (Exception)
                {
                    memStream = webClient.OpenRead(BuildThumbnailUrl(videoIdentifier, Type.HQ));
                }

            }
            catch (Exception) { return null; }

            Image thumbnail = Image.FromStream(memStream);

            memStream.Close();

            return thumbnail;
        }

        /// <summary>
        /// Extracts the Video identifier from the URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns>Video identifier</returns>
        private static string GetVideoIdentifier(string url)
        {
            try
            {
                string identifier = url.Split(new char[] { '=' })[1];

                try
                {
                    if (identifier.Contains("&"))
                    {
                        identifier = identifier.Split(new char[] { '&' })[0];
                    }
                }
                catch (Exception) { }

                return identifier;
            }
            catch (Exception)
            {
                return "";
            }

        }

        /// <summary>
        /// Creates the URl for the Thumbnail location
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Thumbnail URL</returns>
        private static string BuildThumbnailUrl(string videoidentifier, Type type)
        {
            if (type == Type.Maxres)
                return "https://i.ytimg.com/vi/" + videoidentifier + "/maxresdefault.jpg";
            if (type == Type.HQ)
                return "https://i.ytimg.com/vi/" + videoidentifier + "/hqdefault.jpg";
            else
                return "";
        }

        #endregion

        #region Enum

        private enum Type
        {
            Maxres,
            HQ
        }

        #endregion 
    }
}
