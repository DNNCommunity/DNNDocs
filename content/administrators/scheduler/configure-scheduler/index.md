---
uid: configure-scheduler
topic: configure-scheduler
locale: en
title: Configure the Scheduler
dnneditions: 
dnnversion: 09.02.00
---

# Configure the Scheduler

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to Persona Bar \> Settings \> Scheduler.
    
    ![Persona Bar > Settings > Scheduler](/images/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Configure the Scheduler settings.
    
      
    
    ![Host - Advanced - Schedule](/images/scr-HostSchedule-SchedulerMode.png)
    
      
    
    Field
    
    Description
    
    Scheduler Mode
    
    *   Disabled. Prevents all tasks from running.
    *   Timer Method. Runs the scheduled tasks at the specified intervals in separate threads.
    *   Request Method. Runs the scheduled tasks when HTTP requests are made.
    
    Delay Schedule at Start
    
    The number of minutes the system must wait before running scheduled jobs after a restart.