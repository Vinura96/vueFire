<template>
    <div>
        <h1 class="text-center">Li-Iron Battery Test Bench</h1>
        <br />
        <div class="text-center">
            <span><a href="https://localhost:44354/home/RatedCapacity" style="border-style: groove; width: 50%;"><b>Details of Rated Capacity</b></a></span>
            <span class="box" style="font-size:16px;font-weight: bold;text-align:center;margin-bottom:50px; display: inline-block; width: 50%;">
                Rated Capacity =
                <input type="text" name="rc" value="">
            </span>
        </div>
        <br />
        <div class="text-center">
            <span class="box" style="font-size:16px;font-weight: bold;text-align:center;margin-bottom:50px; display: inline-block;">
                State of Health (SOH) =
                <input type="text" name="soh" value="">
            </span>
        </div>
        <br />
        <div class="text-center">
            <span class="box" style="font-size:16px;font-weight: bold;text-align:center;margin-bottom:50px; display: inline-block;">
                State of Charge (SOH) =
                <input type="text" name="soc" value="">
            </span>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/Shortccttest" style="border-style: groove;">Short Circuit Test</a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/ChargeRetention" style="border-style: groove;">Charge Retention And Recovery</a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/ChargeRecovery" style="border-style: groove;">Charge Recovery After Storage</a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/Enduarance"><span style="border-style: groove;">Enduarance In Cycles</span></a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/CCTest" style="border-style: groove;">Continuous Charge Set</a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/OverchargeTest" style="border-style: groove;">Overcharge Test</a>
        </div>
        <br />
        <div class="text-center">
            <a href="https://localhost:44354/home/Result" style="border-style: groove;">Result sheet</a>
        </div>
        <br />
    </div>
</template>
<script>
    export default {
        name: 'home-component'
    };

</script>
<style>
    .grey {
        background-color: lightgray
    }

    .box {
        background-color: lightgrey;
        width: 250px;
        border: 10px solid green;
        padding: 10px;
        margin: 10px;
    }
    a{
        color:#000000;
        text-decoration: none;
    }
</style>