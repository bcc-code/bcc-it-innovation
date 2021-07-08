# Learn terraform for your (and others) good!

This is report from Innovation day for me as I am unable tio attend next day for personal reasons, if you define personal as 'gathering of friends that I have not seen for 1-2 years` as personal. Sorry, I do not like events clashing but it is unavoidable sometimes.

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
### before lunch
This was pretty standard start:
1. Download and install tools
2. Run 'hello-world' of terraform
3. Start reading tutorial on terraform in GCP

Point number 3 was immediately problematic as tutorial is written for using google cloud shell.
Trying to recreate each command in gcloud cli tool ended up in creating service account without needed roles. I then created new account using cloud shell with no problems.

I ended up creating first gcp resource using terrafom: VPC network.


4. Go to second tutorial on modifying terraform plan.

