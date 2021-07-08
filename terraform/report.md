# Learn terraform for your (and others) good!

This is report from Innovation day for me as I am unable to attend next day for personal reasons. For TL:DR version go to [Summary](#summary)

## Goals
This day had more than one goal from my perspective. I will list them and talk shortly about each of them

1. Main goal: learn a bit about terraform, especially in context of GCP
2. Try to decide if pursuing this knowledge later is worth the time.
3. Dont use mouse during the day, or use it sparingly
4. Work inside terminal as much as I can


### Use terminal and no gui

So it quickly turned out, that goals number 3. and 4. are quite big and probably could be its own topic for such day.
I gave up on being super-strict all the time but nonetheless things I try to enforce are as follows:
- try to use vim as much as possible (with my limited understanding of vim)
- try to not use browser for things as checking out if server is working (curl baby!)
- don't use google cloud shell at all (gcloud all the way!)
- try to minimise usage of vs code

#### Why to do this?

Ability to work from terminal environment is priceless in cloud debugging and other operations on remote infrastructure and is really helpful when your OS is some Linux distro. I am ok-ish proficient with unix shells but there is number of tasks I need to use GUI and mouse for. In everyday work it is often big hurdle to try improve your own workflow as it gets in the way of more important things and raises frustration often. So by using Innovation Day for experimenting with this setup I can more easily try to fish for some workflow improvements in work-safe manner.

#### Useful stuff
Some links that might be useful for anyone that uses Linux:
-  [this is curated, small list of really useful, modern cli tools for Linux](https://github.com/ibraheemdev/modern-unix)
- [Much more app but with vasrying quality](https://github.com/agarrharr/awesome-cli-apps)
- [list of zsh plugins](https://github.com/unixorn/awesome-zsh-plugins)
- [VIM tutorial online](https://www.openvim.com/)
- [Vim tutorial as a game](https://vim-adventures.com/)

### Learn terraform

As for main goals (1. and 2.) potential selling points are: 
- ability to keep gcp infratructure-as-a-code
- ability to quickly provision numerous dev/test instances and quickly delete them when not needed

## Day debrief
This was pretty standard start:
1. Download and install tools
2. Run 'hello-world' of terraform
3. Start reading tutorial on terraform in GCP

Point number 3 was immediately problematic as tutorial is written for using google cloud shell.
Trying to recreate each command in gcloud cli tool ended up in creating service account without needed roles. I then created new account using cloud shell with no problems.

I ended up creating first gcp resource using terrafom: VPC network.


4. Go to second tutorial on modifying terraform plan.
During this step I learned that using git only from cli is much harder than I remebered. I guess that is why almost no one knows how to do it nowadays. VS code plugin or git Kraken are definately much more user-friendly.

5. First real problems: 
After reaching step in which we learn about variables good expierience was already lost. Following tutorial to the letter resulted in error when aplying new configration which was not immediately understood by me. From my understanding error was stating that variables are not resolved correctly. After some time of looking for awnsers I decided to go and check different version of same tutorial, deployed in google cloud editor. There I learned tutorials are not exactly the same an, more importantly, terraform versions differ greatly. 

6. Wokring in both versions of a tutorial I managed to go through them up until last point - using already implemented module for managing networks. This failed repeatadly because of terraform version mismatch.

7. At the end I destroyed all resources one last time.

## Summary
I started the day with two, somewhat separate goals:
1. To learn a bit about terraform and how we can use it to control our infrstructure in developer-friendly way
2. To try as much as I can to not use GUI apps and focus on leveraging zsh+vim environment

I can safely say, that I am happy with how far I came with these goals.
At the end of the day I managed to run hundreds of actions (creating, updating and deleting resources) inside GCP almost without touching its UI
which itself is quite impressive. I am sure tutorial experience could be much better, nonetheless I deem this exercise worthy of time spent. Some notes in form of contained points:
- terraform seems to be very powerfull tool
- being able to plan infrastructure in declarative, verbose way and execute these plans almost without human interaction is very good
- learning curve is definately not smooth, as numbers of parameters increase you need to learn about new features quickly, or risk creating a mess not easier to maintain than when configuring every service and resource manually
- secret management becomes yet again more important
- if BCC-ITs is interested in versioning infrastructure changes, terraform will be invaluable in achieving this goal
- tutorial experience for me was mediocore at best

As far as my secondary goal (not using any GUIs whatsever if I can) went, I am very happy:
- additional cli tools that I don't always remember are very handy
- bat (modern cat version) is my favourite cli tool now!
- git-cli is still recipe for disaster if you are not quite advanced with git
- gcloud is really nice, although a bit obtuse (not as much as git)
- vim is good even if you don't know all its magic
- I definately need to learn to use grep, sed and curl much better

To sum it up in one sentences:
It is 100% worthy to pursue using terraform to provision, manage and destroy infrastructure on demand if we want to have infrastructure as a code. 
