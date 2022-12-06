package com.accurx.reliabledownloader;

import org.junit.jupiter.api.Test;

import java.util.concurrent.ExecutionException;

public class DefaultWebSystemCallTest {

    @Test
    public void When_HeadRequested_HeadersReceived() throws ExecutionException, InterruptedException {
        DefaultWebSystemCall webSystemCall = new DefaultWebSystemCall();
        var future = webSystemCall.GetHeaders("https://installer.demo.accurx.com/chain/3.182.57641.0/accuRx.Installer.Local.msi");
        future.thenApply(it -> {
            System.out.println(it);
            return it;
        }).get();
    }

    public void When_GetRequested_ContentReceived() {

    }

}
