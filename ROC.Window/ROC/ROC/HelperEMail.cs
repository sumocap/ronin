using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using EMailEx;

namespace ROC
{
	public class HelperEMail
	{
		EMail _mail = new EMail();

		public void EmailLogFiles()
		{
			Send(
				Configuration.EMail.Default.MailFrom,
				Configuration.EMail.Default.MailSubject,
				Configuration.EMail.Default.MailBody,
				Configuration.EMail.Default.SMTPServer,
				Configuration.EMail.Default.SMTPUsername,
				Configuration.EMail.Default.SMTPPassword,
				true);
		}

		public void EmailLogFiles(string mailFrom, string mailSubject, string mailBody, string smtpServer, string smtpUsername, string smtpPassword, bool withLogs)
		{
			Send(
				mailFrom,
				mailSubject,
				mailBody,
				smtpServer,
				smtpUsername,
				smtpPassword,
				withLogs);
		}

		private void Send(string mailFrom, string mailSubject, string mailBody, string smtpServer, string smtpUsername, string smtpPassword, bool withLogs)
		{
			try
			{
				_mail.SendAsync = false;
				_mail.MailTo = Configuration.EMail.Default.MailTo;

				if (mailFrom == "")
				{
					_mail.MailFrom = GLOBAL.HROM.UserName + "@ronin-capital.com";
				}
				else
				{
					_mail.MailFrom = mailFrom;
				}

				_mail.MailSubject = mailSubject;
				_mail.MailBody = mailBody;

				if (withLogs)
				{
					_mail.MailAttachments = new string[9];

					_mail.MailAttachments[0] = GetAttachmentFilePath(GLOBAL.HLog.ROC.FilePath);
					_mail.MailAttachments[1] = GetAttachmentFilePath(GLOBAL.HLog.USER.FilePath);

					_mail.MailAttachments[2] = GetAttachmentFilePath(GLOBAL.HLog.MDS.FilePath);
					_mail.MailAttachments[3] = GetAttachmentFilePath(GLOBAL.HLog.RDS.FilePath);
					_mail.MailAttachments[4] = GetAttachmentFilePath(GLOBAL.HLog.ROM.FilePath);

					_mail.MailAttachments[5] = GetAttachmentFilePath(GLOBAL.HLog.Orders.FilePath);
					_mail.MailAttachments[6] = GetAttachmentFilePath(GLOBAL.HLog.Positions.FilePath);
					_mail.MailAttachments[7] = GetAttachmentFilePath(GLOBAL.HLog.Trades.FilePath);

					_mail.MailAttachments[8] = GetAttachmentFilePath(GLOBAL.HLog.BMK.FilePath);
				}

				_mail.SMTPServer = smtpServer;
				_mail.SMTPUsername = smtpUsername;
				_mail.SMTPPassword = smtpPassword;
				_mail.Send();
			}
			catch (Exception ex)
			{
				GLOBAL.HROC.AddToException(ex);
			}
		}

		private string GetAttachmentFilePath(string oldFilePath)
		{
			// The file are probably still being used by ROC, make a copy of it
			string newFilePath = oldFilePath.Trim() + ".bak";

			if (oldFilePath != "")
			{
				if (File.Exists(newFilePath))
				{
					File.Delete(newFilePath);
				}
				File.Copy(oldFilePath, newFilePath);
			}

			return newFilePath;
		}
	}
}