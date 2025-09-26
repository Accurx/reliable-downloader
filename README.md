# 👩‍⚕️ Reliable Downloader Exercise 🖥️

[Find out more about Accurx](https://www.accurx.com/careers)

Thank you for investing your time in our take-home exercise.

We've based this exercise on a real problem we've had to solve to be able to release our desktop software, which allows clinicians to communicate with patients over text, video, questionnaires, and other methods to hundreds of thousands of users multiple times a week.

## Why have we set this exercise?

So we get an insight into how you:

- Understand and analyse requirements to solve real user problems
- Utilise language features, structure code and tests to verify your solution meets user requirements

## What is expected of you?

 Please complete 'The Task' detailed below 👇 (you can choose to implement in [C#](./dot-net/ReliableDownloader.sln) or [Java](./java/)) and then answer the following questions in [questions.md](./questions.md)

1. How did you approach solving the problem?
   - _if you used AI assistance we'd love to see examples of your prompts_
2. How did you verify your solution works correctly?
3. How long did you spend on the exercise?
4. If you had more time what would you add and how?

We'd welcome any feedback you have on this exercise in [feedback.md](./feedback.md).

**When you're finished please:**

1. Download your solution, ensuring you include your completed [questions.md](./questions.md) file (in GitHub, at the root of your repository, click Code -> Download Zip)
2. Submit your zipped solution, using the link in your invite email
_(please avoid including your name/email in the zip filename)_

### What does a successful submission look like?

A high-quality submission will:

- meet the task requirements
- make appropriate use of modern language features to solve the problem in an elegant way
- be easy to read and reason about
- have unit tests around the range requests implementation
- have evidence that the resilience mechanism has been manually tested (we will run it ourselves and review your answer to question #2 in [questions.md](./questions.md))

### Tips

- take the time to read through the task and description
- imagine you are submitting this for PR review, add some code comments as you might on a PR if you think it will be helpful to share your thought process (we recommend [conventional comments](https://conventionalcomments.org/))
- prioritise implementing the requirements but do spend some time refactoring to improve your design
- you can throttle your internet connection using NetLimiter or similar
- you can simulate internet disconnections by disconnecting wifi/ethernet
- the use of third-party libraries is encouraged but we recommend keeping to well-established libraries (unless there's one you're really excited to share with us, please use [questions.md](./questions.md) to tell us about it)

## The Task

Clinicians are faced with unreliable network conditions including intermittent disconnection and low bandwidth.  The downloader they use to get the latest updates to our desktop app needs to work reliably in these challenging conditions.

We've provided a basic implementation of the downloader that downloads a file from a URL to disk and verifies its integrity.  Your challenge is to extend it to:

1. be resilient to network disconnections of _any_ length (from a couple of seconds to over two minutes)
2. where the CDN supports [range requests](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Ranges), download the file in chunks and
3. pick up where it left off if the user restarts the installer
4. ensure the downloaded file is valid before the download is considered complete
5. you can test your solution against the download [url](https://web.dev.accurx.com/api/desktop/download/unreliable?delay=<milliseconds>) which simulates the various unreliable testing conditions
