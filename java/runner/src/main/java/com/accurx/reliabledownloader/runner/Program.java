package com.accurx.reliabledownloader.runner;

import com.accurx.reliabledownloader.FileDownloadSettings;
import com.accurx.reliabledownloader.FileDownloaderImpl;

import java.net.URI;
import java.net.http.HttpClient;
import java.nio.file.Path;

public class Program {

    private static final FileDownloadSettings downloadSettings = new FileDownloadSettings(
            // Replace the URL below with https://web.dev.accurx.com/api/desktop/download/unreliable?delay=<milliseconds> to test against the unreliable server. You can adjust the optional delay parameter by replacing <milliseconds> with the number of milliseconds you want to simulate between responses in the stream.
            URI.create("https://installer.accurx.com/chain/4.22.50587.0/accuRx.Installer.Local.msi"),
            Path.of("myfirstdownload.msi")
    );

    public static void main(String[] args) throws Exception {

        FileDownloadCommand fileDownloadCommand = new FileDownloadCommand(
                new FileDownloaderImpl(
                        HttpClient.newBuilder()
                ),
                downloadSettings
        );
        fileDownloadCommand.run();
    }
}